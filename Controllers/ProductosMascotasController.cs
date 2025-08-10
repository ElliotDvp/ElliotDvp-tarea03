using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TuProyecto.Models;

namespace TuProyecto.Controllers
{
    public class ProductosMascotasController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<ProductoMascota>
            {
                new ProductoMascota { Id = 1, Nombre = "Croquetas Premium", Categoria = "Alimento", Precio = 50.00M, Stock = 20 },
                new ProductoMascota { Id = 2, Nombre = "Pelota de Goma", Categoria = "Juguete", Precio = 15.00M, Stock = 50 }
            };

            return View(productos);
        }
    }
}
