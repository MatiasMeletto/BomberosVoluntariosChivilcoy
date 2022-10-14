using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Componentes;
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
        public EstadoBombero Estado { get; set; } 
        public DateTime FechaAceptacion { get; set; }
        public EscalafonJerarquico Grado { get; set; }
        [Required, StringLength(255)]
        public string Dotacion { get; set; } // Tiene que ser un enum (1, 2, 3, 4)
        [Required, StringLength(255)]
        public string Brigada { get; set; } // ¿Debería ser una clase y una relación?
        [StringLength(255)]
        public string? Resolucion1 { get; set; }
        [StringLength(255)]
        public string? Resolucion2 { get; set; }
        [StringLength(255)]
        public string? Resolucion3 { get; set; }
        [StringLength(255)]
        public string? Resolucion4 { get; set; }
        [StringLength(255)]
        public string? Resolucion5 { get; set; }
        [StringLength(255)]
        public string? Resolucion6 { get; set; }
        public bool Chofer { get; set; }
        public DateOnly? VencimientoRegistro { get; set; }

        public List<VehiculoPersonal> Vehiculos { get; set; } = new();

        public MovilBombero? Movil { get; set; }

        public BomberoDependencia? Dependencia { get; set; }

        public List<Incidente> Incidentes { get; set; } = new();

        public List<BomberoSalida> Salidas { get; set; } = new();

    }
}
