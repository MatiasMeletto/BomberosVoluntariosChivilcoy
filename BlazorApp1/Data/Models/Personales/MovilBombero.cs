using BlazorApp1.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Models.Personales
{
    [Index(nameof(PerosnaId))]
    [Index(nameof(MovilId), nameof(PerosnaId))]
    public class MovilBombero
    {
        public int MovilBomberoId { get; set; }

        public TipoRol Rol { get; set; }

        public int MovilId { get; set; }
        public Movil Movil { get; set; }

        public int PerosnaId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
