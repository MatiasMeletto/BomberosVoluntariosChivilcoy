using BlazorApp1.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Personales
{
    [Index(nameof(PersonaId))]
    [Index(nameof(VehiculoId), nameof(PersonaId))]
    public class MovilBombero
    {
        public int MovilBomberoId { get; set; }

        public TipoRol Rol { get; set; }

        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Movil Movil { get; set; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }
    }
}
