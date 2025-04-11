using ConlagoS__Liga_Pro_de_Ecuador.Models;
using ConlagoS__Liga_Pro_de_Ecuador.Repos;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConlagoS__Liga_Pro_de_Ecuador.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult List()
        {
            
            EquipoRepos repositorio = new EquipoRepos();
            var Equipo = repositorio.DevuelveEstadosEquipo();

            return View(Equipo);
        }
    }
}
