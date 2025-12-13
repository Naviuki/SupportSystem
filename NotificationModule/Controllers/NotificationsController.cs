using Microsoft.AspNetCore.Mvc;
using NotificationModule.Models;
using NotificationModule.Services;

namespace NotificationModule.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NotificationsController : ControllerBase
{
    private readonly NotificationService _service;

    public NotificationsController(NotificationService service)
    {
        _service = service;
    }

    [HttpPost]
    public IActionResult Send([FromBody] NotificationRequest req)
    {
        var response = _service.Send(req);
        return Ok(response);
    }
}
