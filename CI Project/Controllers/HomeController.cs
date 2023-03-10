using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CI_Project.Models;

namespace CI_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult login()
    {
        return View();
    }

    public IActionResult Forgot_password()
    {
        return View();
    }

    public IActionResult Registration()
    {
        return View();
    }

    public IActionResult reset()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

