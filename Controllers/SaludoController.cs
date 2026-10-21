using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HolaMVC.Models;

namespace HolaMVC.Controllers;

public class SaludoController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View(new Persona());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Index(Persona persona)
    {
        // Validar el modelo
        if (!ModelState.IsValid)
        {
            return View(persona);
        }
        
        return View("Resultado", persona);
    }
}