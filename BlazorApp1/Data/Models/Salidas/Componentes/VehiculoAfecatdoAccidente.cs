using BlazorApp1.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectadoAccidente : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Accidente Accidente { get; set; }
    }
}