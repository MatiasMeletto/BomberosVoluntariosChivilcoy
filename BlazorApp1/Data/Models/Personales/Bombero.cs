using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Models.Personales
{
    [Index(nameof(NumeroLegajo))]
    public class Bombero : Persona
    {
        public int NumeroLegajo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public string Dotacion { get; set; }
        public string Brigada { get; set; }
        public string Resolucion1 { get; set; }
        public string Resolucion2 { get; set; }
        public string Resolucion3 { get; set; }
        public string Resolucion4 { get; set; }
        public string Resolucion5 { get; set; }
        public string Resolucion6 { get; set; }
        public bool Chofer { get; set; }
        public DateTime? VencimientoRegistro { get; set; }

        public List<Vehiculo>? Vehiculos { get; set; } = new();

        public int? MovilBomberoId { get; set; }
        public MovilBombero? Movil { get; set; }

        public List<BomberoSalida> Salidas { get; set; } = new();
    }
}
