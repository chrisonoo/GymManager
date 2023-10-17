using System.Diagnostics;

using GymManager.Application.Tickets.Commands.AddTicket;
using GymManager.UI.Models;

using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;
public class HomeController : BaseController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        await Mediator.Send(new AddTicketCommand { Name = "Test" });

        return View();
    }

    public IActionResult Privacy()
    {
        // throw new Exception("Unhandled error");

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
