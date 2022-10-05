using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Planillas;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Personales
{
    [Index(nameof(NumeroLegajo))]
    public class Bombero : Persona
    {
        [Required]
        public int NumeroLegajo { get; set; }
        public string Estado { get; set; } // Tiene que ser un enum
        public DateTime FechaAceptacion { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        public string Dotacion { get; set; } // Tiene que ser un enum (1, 2, 3, 4)
        public string Brigada { get; set; } // ¿Debería ser una clase y una relación?
        public string? Resolucion1 { get; set; }
        public string? Resolucion2 { get; set; }
        public string? Resolucion3 { get; set; }
        public string? Resolucion4 { get; set; }
        public string? Resolucion5 { get; set; }
        public string? Resolucion6 { get; set; }
        public bool Chofer { get; set; }
        public DateTime? VencimientoRegistro { get; set; }

        public List<VehiculoPersonal> Vehiculos { get; set; } = new();

        public MovilBombero? Movil { get; set; }

        public List<BomberoSalida> Salidas { get; set; } = new();

    }
}
