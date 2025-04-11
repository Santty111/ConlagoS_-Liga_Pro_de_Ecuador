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
                PartidosPerdidos = 10,
                PartidosEmpatados = 10,
                TotalPuntos = 30
            };

            Equipo BSC = new Equipo

            {
                IdEquipo = 2,
                Nombre = "BSC",
                PartidosJugados = 10,
                PartidosGanados = 1,
                PartidosPerdidos = 0,
                PartidosEmpatados = 9,
                TotalPuntos = 30
            };
            equipos.Add(ldu);
            equipos.Add(BSC);


            return equipos;
        }
    }
}
