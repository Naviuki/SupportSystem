namespace TicketModule.Models;

public class TicketRequest
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Category { get; set; } = "";
    public string Priority { get; set; } = "";
    public string UserEmail { get; set; } = "";
    public string UserName { get; set; } = "";
}
