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
                    return RedirectToAction("List"); 
                }
                return View(equipo); 
            }
            catch (Exception)
            {
                return View(equipo); 
            }
        }
        
        public IActionResult CrearEquipo()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult CrearEquipo(Equipo nuevoEquipo)
        {
            try
            {
                var equiposActuales = _repository.DevuelveEstadosEquipo().ToList();

                
                if (equiposActuales.Any(e => e.IdEquipo == nuevoEquipo.IdEquipo))
                {
                    ModelState.AddModelError("IdEquipo", "Ya existe un equipo con ese ID");
                    return View(nuevoEquipo);
                }

                equiposActuales.Add(nuevoEquipo);
                _repository.SetEquipos(equiposActuales);

                return RedirectToAction("List");
            }
            catch
            {
                return View(nuevoEquipo);
            }
        }

        public IActionResult DetalleEquipo(int id)
        {
            var equipo = _repository.DevuelveInformacionEquipo(id);
            var equipos = _repository.DevuelveEstadosEquipo();

            bool esFavorito = equipo.TotalPuntos == equipos.Max(e => e.TotalPuntos);
            ViewBag.EsFavorito = esFavorito;

            return View(equipo);
        }

    }
}
