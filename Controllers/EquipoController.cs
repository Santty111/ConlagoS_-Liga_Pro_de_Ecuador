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
                var actualizado = _repository.ActualizarEquipo(equipo);
                if (actualizado)
                {
                    return RedirectToAction("List"); // Vuelve a la tabla principal
                }
                return View(equipo); // Por si falla
            }
            catch (Exception)
            {
                return View(equipo); // Podrías mostrar un mensaje de error si quieres
            }
        }
        //CREAREQUIPO
        public IActionResult CrearEquipo()
        {
            return View(); // Devuelve la vista vacía para crear
        }

        [HttpPost]
        public IActionResult CrearEquipo(Equipo nuevoEquipo)
        {
            try
            {
                var equiposActuales = _repository.DevuelveEstadosEquipo().ToList();

                // Verifica que no exista ya un equipo con el mismo ID
                if (equiposActuales.Any(e => e.IdEquipo == nuevoEquipo.IdEquipo))
                {
                    ModelState.AddModelError("IdEquipo", "Ya existe un equipo con ese ID");
                    return View(nuevoEquipo);
                }

                equiposActuales.Add(nuevoEquipo);
                _repository.SetEquipos(equiposActuales); // Usa este método (ver abajo)

                return RedirectToAction("List");
            }
            catch
            {
                return View(nuevoEquipo);
            }
        }
    }
}
