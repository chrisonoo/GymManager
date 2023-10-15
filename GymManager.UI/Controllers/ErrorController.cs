using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;

public class ErrorController : Controller
{
    [HttpGet("/Error")]
    public IActionResult Index()
    {
        return View("Error");
    }
}
