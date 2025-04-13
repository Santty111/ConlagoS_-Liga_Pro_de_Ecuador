using ConlagoS__Liga_Pro_de_Ecuador.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConlagoS__Liga_Pro_de_Ecuador.Repos
{
    public class EquipoRepos
    {
        public IEnumerable<Equipo> DevuelveEstadosEquipo()

        {
            List<Equipo> equipos = new List<Equipo>();
            Equipo ldu = new Equipo
            {
                IdEquipo = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            };

            Equipo BSC = new Equipo

            {
                IdEquipo = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosPerdidos = 9,
                PartidosEmpatados = 0
            };
            equipos.Add(ldu);
            equipos.Add(BSC);

            equipos = equipos.OrderBy(item=>item.TotalPuntos).ToList();

            return equipos;
        }

        public Equipo DevuelveInformacionEquipo(int Id)
        {
            var equipos = DevuelveEstadosEquipo();
            var equipo = equipos.First(item =>  item.IdEquipo == Id);
            return equipo;
        }
        public bool ActualizarEquipo(Equipo equipo)
        {
            //Logica para actulizar
            return true;
        }
    }
}
