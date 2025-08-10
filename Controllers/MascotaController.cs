using Microsoft.AspNetCore.Mvc;
using ElliotDvp_tarea03.Models;

public class MascotaController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Enviar(Mascota mascota)
    {
        if (ModelState.IsValid)
        {

            // Aquí podrías guardar la mascota en una base de datos o realizar otra acción
            ViewBag.Mensaje = "Mascota registrada correctamente";
            return View("Index");
        }
        else
        {
            // Si hay errores de validación, regresamos a la vista con los datos ingresados
            ViewBag.Mensaje = "Por favor, corrija los errores";
            return View("Index", mascota);
        }

    }
}