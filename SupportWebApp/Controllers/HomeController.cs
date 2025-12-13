using Microsoft.AspNetCore.Mvc;

namespace SupportWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    public IActionResult Operator()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return RedirectToAction("Operator");
    }

}
