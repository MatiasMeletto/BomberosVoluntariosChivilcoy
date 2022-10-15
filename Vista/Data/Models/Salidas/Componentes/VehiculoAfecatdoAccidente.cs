using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectadoAccidente : VehiculoAfectado
    {
        [ForeignKey("SalidaId")]
        public Accidente Accidente { get; set; }
    }
}