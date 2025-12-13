using NotificationModule.Models;

namespace NotificationModule.Services;

public class NotificationService
{
    public NotificationResponse Send(NotificationRequest request)
    {
        Console.WriteLine($"Отправлено уведомление о заявке #{request.TicketId} на {request.Email}");
        return new NotificationResponse(true, "Уведомление доставлено");
    }
}
