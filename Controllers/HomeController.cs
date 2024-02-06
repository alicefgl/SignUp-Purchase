using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using foglietta.alice._5i.signup.Models;

namespace foglietta.alice._5i.signup.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Prenotazione> Prenotazioni;
    private List<Prodotto> Prodotti;
    private static Prodotto[] vett = new Prodotto[4];

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Prenotazioni = new List<Prenotazione>();
        Prodotti = new List<Prodotto>();

    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Conferma(Prenotazione p)
    {
        Prenotazioni.Add(p);
        return View(Prenotazioni);
    }


    [HttpGet]
    public IActionResult Purchase()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Cart(Prodotto prod)
    {
        Prodotti.Add(prod);
        return View(Prodotti);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}