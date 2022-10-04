using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Personales
{
    public class Movil : Vehiculo
    {
        public string NumeroMovil { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public TipoEstadoMovil Estado { get; set; }

        public List<MovilBombero> Bomberos { get; set; } = new();
        public List<MovilSalida> Salidas { get; set; } = new();
    }
}
