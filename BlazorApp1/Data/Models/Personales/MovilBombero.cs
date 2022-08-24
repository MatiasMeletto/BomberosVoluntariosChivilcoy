using BlazorApp1.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Models.Personales
{
    [Index(nameof(BomberoId))]
    [Index(nameof(MovilId), nameof(BomberoId))]
    public class MovilBombero
    {
        public int MovilBomberoId { get; set; }

        public TipoRol Rol { get; set; }

        public int MovilId { get; set; }
        public Movil Movil { get; set; }

        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
