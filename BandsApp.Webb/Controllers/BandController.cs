using BandsApp.Webb.Services;
using Microsoft.AspNetCore.Mvc;
using BandsApp.Webb.Models;



namespace BandsApp.Webb.Controllers;


public class BandController : Controller
{
    private readonly BandService _bandService = new ();

    [HttpGet("")]
    public IActionResult Index()
    {
            var band = _bandService.GetAllBands();
            return View(band);
    }

    [HttpGet("Details/{id:int}")]
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
