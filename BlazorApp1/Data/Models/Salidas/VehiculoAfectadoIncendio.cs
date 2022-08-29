using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas
{
    public class VehiculoAfectadoIncendio : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Incendio Incendio { get; set; }
    }
}
