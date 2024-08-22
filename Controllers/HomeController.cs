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

    public IActionResult Deportes()
    {
        ViewBag.ListaDeportes=BD.ListarDeportes();
        return View();
    }
    public IActionResult Paises()
    {
        ViewBag.ListarPaises=BD.ListarPaises();
        return View();
    }
    public IActionResult VerDetalleDeporte(int idDeporte)
    {
        ViewBag.DeporteElegido=BD.VerInfoDeporte(idDeporte);
        ViewBag.ListaDeportistasxDeporte=BD.ListarDeportistasxDeporte(idDeporte);
        return View();
    }
    public IActionResult VerDetallePais(int idPais)
    {
        ViewBag.DeporteElegido=BD.VerInfoPais(idPais);
        ViewBag.ListaDeportistasxDeporte=BD.ListarDeportistasxDeporte(idPais);
        return View();
    }
}
