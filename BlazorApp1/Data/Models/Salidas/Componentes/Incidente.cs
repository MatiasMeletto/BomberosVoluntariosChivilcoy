using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class Incidente
    {
        public int IncidenteId { get; set; }

        [Required, StringLength(255)]
        public string Observacion { get; set; }
        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }
        [ForeignKey("PersonaId")]
        public Bombero QuienHizo { get; set; }
    }
}
