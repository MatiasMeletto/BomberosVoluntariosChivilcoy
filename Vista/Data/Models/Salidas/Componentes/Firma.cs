using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Vista.Data.Models.Personales;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Firma
    {
        public int FirmaId { get; set; }
        public DateTime FechaHora { get; set; }
        [Required, StringLength(255)]
        public string Detalle { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero Bombero { get; set; }
        public int VehiculoId { get; set; }
        [ForeignKey("VehiculoId")]
        public Movil Movil { get; set; }
    }
}
