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
                new ProductoMascota { Id = 1, Nombre = "Croquetas Premium", Categoria = "Alimento", Precio = 50.00M, Stock = 30, Url = "https://http2.mlstatic.com/D_NQ_NP_825063-MLU70666211215_072023-O.webp" },
                new ProductoMascota { Id = 2, Nombre = "Pelota de Goma", Categoria = "Juguete", Precio = 15.00M, Stock = 50, Url = "https://media.falabella.com/falabellaPE/132056012_01/w=800,h=800,fit=pad" },
                new ProductoMascota { Id = 3, Nombre = "Hueso falso", Categoria = "Juguete", Precio = 5.0M, Stock = 20, Url = "https://thumbs.dreamstime.com/z/hueso-falso-para-los-perros-38566554.jpg" },
            };


            return View(productos);
        }
    }
}
