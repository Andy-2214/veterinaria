using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class MascotasController : Controller
    {
        public IActionResult Mascota()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Registro(Mascota mascota)
        {
            if (ModelState.IsValid)
            {
                TempData["Mensaje"] = "Mascota registrada correctamente";
                return RedirectToAction("Registrado");
            }
            return View(mascota);
        }

        public IActionResult Registrado()
       {
            return View();
       }
    }
}
