using System.Net.Http.Json;

namespace TicketModule.Services;

public class NotificationClient
{
    private readonly HttpClient _httpClient;

    public NotificationClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:5001");
    }

    // ✅ Исправлено: SendNotificationAsync
    public async Task<bool> SendNotificationAsync(int ticketId, string email)
    {
        try
        {
            var request = new { TicketId = ticketId, Email = email };
            var response = await _httpClient.PostAsJsonAsync("/api/notifications", request);

            Console.WriteLine($"[NOTIFICATION] Заявка #{ticketId} → {email}: {(response.IsSuccessStatusCode ? "OK" : "ERROR")}");
            return response.IsSuccessStatusCode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[NOTIFICATION ERROR] {ex.Message}");
            return false;
        }
    }
}
