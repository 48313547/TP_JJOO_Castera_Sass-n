using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP_JJOO_Castera_Sass_n.Models;

namespace TP_JJOO_Castera_Sass_n.Controllers;

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
}
