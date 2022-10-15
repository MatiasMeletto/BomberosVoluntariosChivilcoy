using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class InicidenteMovil : Incidente
    {
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Movil Movil { get; set; }
    }
}
