using BandsApp.Webb.Services;
using Microsoft.AspNetCore.Mvc;


namespace BandsApp.Webb.Controllers;

public class BandController : Controller
{
    private readonly BandService _bandService = new ();

    [Route("/")]
    public IActionResult Index()
    {
            var bands = _bandService.GetAllBands();
            return View(bands);
    }

    [Route("/details/{id:int}")]
    public IActionResult Details(int id)
    {
        var band = _bandService.GetBandById(id);
        if (band == null)
        {
            return NotFound();
        }
        return View(band);
    }














}
