using BlazorApp1.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectadoIncendio : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Incendio Incendio { get; set; }
    }
}
