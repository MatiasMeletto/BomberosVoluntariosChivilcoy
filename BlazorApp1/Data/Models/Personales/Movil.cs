using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Personales
{
    public class Movil : Vehiculo
    {
        public string NumeroMovil { get; set; }
        [Required, StringLength(255)]
        public string NumeroMotor { get; set; }
        [Required, StringLength(255)]
        public string NumeroChasis { get; set; }
        [Required, StringLength(255)]
        public TipoEstadoMovil Estado { get; set; }

        public List<MovilBombero> Bomberos { get; set; } = new();

        public List<MovilSalida> Salidas { get; set; } = new();

        public List<Incidente> Incidentes { get; set; } = new();
    }
}
