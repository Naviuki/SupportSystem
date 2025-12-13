using TicketModule.Models;
using System.Collections.Concurrent;

namespace TicketModule.Services;

public class TicketService
{
    private static int _nextId = 1;
    private static readonly ConcurrentDictionary<int, Ticket> _tickets = new();

    public TicketResponse CreateTicket(TicketRequest request)
    {
        // Валидация
        if (string.IsNullOrWhiteSpace(request.Title) || string.IsNullOrWhiteSpace(request.UserEmail))
        {
            return new TicketResponse
            {
                Success = false,
                Code = "VALIDATION_ERROR",
                Message = "Title и UserEmail обязательны"
            };
        }

        var ticket = new Ticket
        {
            Id = _nextId++,
            Title = request.Title,
            Description = request.Description,
            UserEmail = request.UserEmail,
            Status = "New"
        };

        _tickets[ticket.Id] = ticket;
        Console.WriteLine($"[TICKET #{ticket.Id}] {request.Title}");

        return new TicketResponse
        {
            Success = true,
            Code = "CREATED",
            Message = "Заявка создана успешно",
            TicketId = ticket.Id
        };
    }

    public bool DeleteTicket(int id)
    {
        return _tickets.TryRemove(id, out _);
    }

    // возвращаем List<object>
    public List<object> GetAllTickets()
    {
        return _tickets.Values
            .OrderBy(t => t.CreatedAt)
            .Select(t => new object[] {
                new {
                    id = t.Id,
                    title = t.Title,
                    description = t.Description,
                    userEmail = t.UserEmail,
                    status = t.Status,
                    createdAt = t.CreatedAt
                }
            }.First())
            .ToList();
    }
}

public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string UserEmail { get; set; } = "";
    public string Status { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
