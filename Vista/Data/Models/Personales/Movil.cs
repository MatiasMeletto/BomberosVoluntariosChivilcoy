using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Componentes;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Personales
{
    [Index(nameof(NumeroMovil))]
    public class Movil : Vehiculo
    {
        [Required, StringLength(255)]
        public string NumeroMovil { get; set; }
        [Required, StringLength(255)]
        public string NumeroMotor { get; set; }
        [Required, StringLength(255)]
        public string NumeroChasis { get; set; }
        public TipoEstadoMovil Estado { get; set; }
        public ImagenMovil Imagen { get; set; }

        public List<MovilBombero> Bomberos { get; set; } = new();

        public List<MovilSalida> Salidas { get; set; } = new();

        public List<Incidente> Incidentes { get; set; } = new();
    }
}
