namespace TicketModule.Models;

public class TicketResponse
{
    public bool Success { get; set; }
    public string Code { get; set; } = "";
    public string Message { get; set; } = "";
    public int TicketId { get; set; }
}
