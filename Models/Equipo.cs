using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ConlagoS__Liga_Pro_de_Ecuador.Models
{
    public class Equipo
    {
        [Key]
        public int IdEquipo { get; set; }

        [Required]
        [MaxLength(100)]
        [DisplayName("Ingrese el nombre del equipo")]
        public string Nombre { get; set; }

        [Range(0, 20)]
        public int PartidosJugados { get; set; }
        [Range(0, 20)]
        public int PartidosGanados { get; set; }
        [Range(0, 20)]
        public int PartidosEmpatados { get; set; }
        [Range(0, 20)]
        public int PartidosPerdidos { get; set; }
        public int TotalPuntos {
            get
            {
                int total_puntos=PartidosGanados *3 + PartidosEmpatados;
                return total_puntos;
            }
        }
    }
}
