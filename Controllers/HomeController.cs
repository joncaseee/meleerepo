using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MeleeMusicNet.Models;

namespace MeleeMusicNet.Controllers;

public class HomeController : Controller
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

    // public IActionResult Artists()
    // {
    //     return View();
    // }

    public IActionResult Mixes()
    {
        return View();
    }

    public IActionResult Releases()
    {
        return View();
    }

    public IActionResult Connect()
    {
        return View();
    }

    public IActionResult BlockParty()
    {
        return View();
    }

    public IActionResult LocationRequested()
    {
        return View();
    }

    public IActionResult LocationAnnouncement()
    {
        return View();
    }

    public IActionResult Submissions()
    {
        return View();
    }



    public IActionResult SubmissionSuccess()
    {
        return View();
    }

    public IActionResult EmailSuccess()
    {
        return View();
    }

    public IActionResult Artists2()
    {
        return View();
    }

    public IActionResult Submit2()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

