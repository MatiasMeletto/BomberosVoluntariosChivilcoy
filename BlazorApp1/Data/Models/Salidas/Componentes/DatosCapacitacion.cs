using Vista.Data.Enums;
using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class DatosCapacitacion
    {
        public int DatosCapacitacionId { get; set; }

        public TipoNivelCapacitacion? NivelCapacitacion { get; set; }
        [StringLength(255)]
        public string? NivelCapacitacionOtro { get; set; }
        public TipoCapacitacion? TipoCapacitacion { get; set; }
        [StringLength(255)]
        public string? CapacitacionOtra { get; set; }
        [Required, StringLength(255)]
        public string DiasCapacitacion { get; set; }
        [Required, StringLength(255)]
        public string HorariosCapacitacion { get; set; }

        public int SalidaId { get; set; }
        [ForeignKey("SalidaId")]
        public ServicioEspecial ServicioEspecial { get; set; }
    }
}
