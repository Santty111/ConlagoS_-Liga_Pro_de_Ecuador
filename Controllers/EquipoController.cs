using ConlagoS__Liga_Pro_de_Ecuador.Models;
using ConlagoS__Liga_Pro_de_Ecuador.Repos;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConlagoS__Liga_Pro_de_Ecuador.Controllers
{
    public class EquipoController : Controller
    {

        public EquipoRepos _repository;

        public EquipoController()
        {
            _repository = new EquipoRepos();
        }

        public IActionResult List()
        {

            var equipos = _repository.DevuelveEstadosEquipo();

            return View(equipos);
        }
        public IActionResult EditarEquipo(int Id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(Id);
            return View(equipo);
        }

        [HttpPost]
        public IActionResult EditarEquipo(Equipo equipo)
        {
            try
            {
                var actulizar = _repository.ActualizarEquipo(equipo);
                return View();
            }
            catch (Exception e) 
            {
                throw;
            }

        }
    }
}
