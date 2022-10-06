using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Personales
{
    public abstract class Vehiculo
    {
        public int VehiculoId { get; set; }

        [Required, StringLength(255)]
        public string Marca { get; set; }
        [Required, StringLength(255)]
        public string Modelo { get; set; }
        [Required, StringLength(255)]
        public int Año { get; set; }
        public string Patente { get; set; }
        [Required, StringLength(255)]
        public string Tipo { get; set; }

        public int SeguroId { get; set; }
        public SeguroVehiculo Seguro { get; set; }
    }
}
