using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using System.Collections.Generic;

namespace Veterinaria.Controllers
{
    public class ProductosController : Controller
    {
        private static List<Productos> productos = new List<Productos>()
        {
            new Productos { Id = 1, Nombre = "Collar para perro", Precio = 25.00m, Descripcion = "Collar ajustable para perro mediano." },
            new Productos { Id = 2, Nombre = "Pelota de goma", Precio = 10.00m, Descripcion = "Pelota resistente para jugar." },
            new Productos { Id = 3, Nombre = "Comida para gatos (1kg)", Precio = 35.00m, Descripcion = "Comida balanceada para gatos adultos." }
        };

        public IActionResult Productos()
        {
            return View(productos);
        }
    }
}
