using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas
{
    public class VehiculoAfectadoAccidente : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Accidente Accidente { get; set; }
    }
}