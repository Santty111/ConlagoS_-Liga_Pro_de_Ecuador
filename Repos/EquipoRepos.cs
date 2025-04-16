using ConlagoS__Liga_Pro_de_Ecuador.Models;

namespace ConlagoS__Liga_Pro_de_Ecuador.Repos
{
    public class EquipoRepos
    {
        private static List<Equipo> equipos = new List<Equipo>
        {
            new Equipo
            {
                IdEquipo = 1,
                Nombre = "LDU",
                PartidosJugados = 10,
                PartidosGanados = 10,
                PartidosPerdidos = 0,
                PartidosEmpatados = 0
            },
            new Equipo
            {
                IdEquipo = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 3,
                PartidosPerdidos = 3,
                PartidosEmpatados = 4
            },
            new Equipo
            {
                IdEquipo = 3,
                Nombre = "Emelec",
                PartidosJugados = 10,
                PartidosGanados = 5,
                PartidosPerdidos = 2,
                PartidosEmpatados = 3
            },
              new Equipo
            {
                IdEquipo = 4,
                Nombre = "Mushuc Runa",
                PartidosJugados = 10,
                PartidosGanados = 6,
                PartidosPerdidos = 1,
                PartidosEmpatados = 3
            },
               new Equipo
            {
                IdEquipo = 5,
                Nombre = "IDV",
                PartidosJugados = 10,
                PartidosGanados = 9,
                PartidosPerdidos = 0,
                PartidosEmpatados = 1
            }

        };

        public IEnumerable<Equipo> DevuelveEstadosEquipo()
        {
            return equipos.OrderByDescending(item => item.TotalPuntos).ToList();
        }

        public Equipo DevuelveInformacionEquipo(int Id)
        {
            return equipos.FirstOrDefault(e => e.IdEquipo == Id);
        }

        public bool ActualizarEquipo(Equipo equipo)
        {
            var original = equipos.FirstOrDefault(e => e.IdEquipo == equipo.IdEquipo);
            if (original != null)
            {
                original.Nombre = equipo.Nombre;
                original.PartidosJugados = equipo.PartidosJugados;
                original.PartidosGanados = equipo.PartidosGanados;
                original.PartidosEmpatados = equipo.PartidosEmpatados;
                original.PartidosPerdidos = equipo.PartidosPerdidos;
                return true;
            }
            return false;
        }

        public void SetEquipos(List<Equipo> nuevosEquipos)
        {
            equipos = nuevosEquipos;
        }
    }
}
