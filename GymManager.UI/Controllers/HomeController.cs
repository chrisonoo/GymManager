using GymManager.Application.Contacts.Commands.SendContactEmail;

using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;
public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View(new SendContactEmailCommand());
    }

    [ValidateAntiForgeryToken]
    [HttpPost]
    public async Task<IActionResult> Contact(SendContactEmailCommand command)
    {
        await Mediator.Send(command);

        return RedirectToAction(nameof(Contact));
    }
}
