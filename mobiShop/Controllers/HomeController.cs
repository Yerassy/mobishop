using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mobiShop.Models;

namespace mobiShop.Controllers;

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
    public IActionResult About()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Brand()
    {
        return View();
    }

    public IActionResult Special()
    {
        return View();
    }
    
}
