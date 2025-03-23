using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspNetCrudBasico.Models;
using AspNetCrudBasico.Models.ViewModel;

namespace AspNetCrudBasico.Controllers;

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

    public IActionResult FilmesAjax(string? Categoria, string? Nome, int? AnoLancamento)
    {
        return ViewComponent("ListaFilmes", new { Categoria = Categoria, Nome = Nome, AnoLancamento = AnoLancamento });
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
