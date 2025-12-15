using Microsoft.AspNetCore.Mvc;
using TicketModule.Models;
using TicketModule.Services;

namespace TicketModule.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private readonly TicketService _ticketService;
    private readonly NotificationClient _notificationClient;

    public TicketsController(TicketService ticketService, NotificationClient notificationClient)
    {
        _ticketService = ticketService;
        _notificationClient = notificationClient;
    }

    // POST /api/tickets
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TicketRequest? request)
    {
        Console.WriteLine("POST /api/tickets");

        if (request == null)
            return BadRequest(new TicketResponse { Success = false, Code = "NULL_REQUEST", Message = "Запрос пустой" });

        var result = _ticketService.CreateTicket(request);

        if (!result.Success)
            return BadRequest(result);

        // Отправляем уведомление (тест-кейс 7)
        await _notificationClient.SendNotificationAsync(result.TicketId, request.UserEmail);

        return Ok(result);
    }

    // DELETE api/tickets/{id}
    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var success = _ticketService.DeleteTicket(id);
        if (success)
            return Ok(new { success = true, message = $"Заявка #{id} удалена" });
        else
            return NotFound(new { success = false, message = $"Заявка #{id} не найдена" });
    }

    // PATCH api/tickets/{id}/complete ✅ НОВЫЙ ENDPOINT
    [HttpPatch("{id:int}/complete")]
    public async Task<IActionResult> CompleteTicket(int id)
    {
        var result = await _ticketService.CompleteTicketAsync(id);

        if (result.Success)
            return Ok(new { success = true, message = result.Message });
        else
            return NotFound(new { success = false, message = result.Message });
    }

    // GET /api/tickets
    [HttpGet]
    public IActionResult GetTickets()
    {
        var tickets = _ticketService.GetAllTickets();
        return Ok(tickets);
    }
}
