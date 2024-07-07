using ManejoPresupuesto.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManejoPresupuesto.Controllers
{
    public class TiposCuentasController : Controller
    {
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(TipoCuenta tipoCuenta)
        {
            // Si el modelo no es valido (returnamos a la vista para mensajes de error)
            if (!ModelState.IsValid)
            {
                return View(tipoCuenta);
            }

            return View();
        }

    }
}
