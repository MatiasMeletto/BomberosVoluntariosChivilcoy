using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectadoIncendio : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Incendio Incendio { get; set; }
    }
}
