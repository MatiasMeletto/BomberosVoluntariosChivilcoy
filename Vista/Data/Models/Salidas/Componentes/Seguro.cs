using Vista.Data.Models.Personales;
using Vista.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Componentes
{
    public abstract class Seguro
    {
        public int SeguroId { get; set; }
        [Required, StringLength(255)]
        public string CompañiaAseguradora { get; set; }
        [Required, StringLength(255)]
        public string NumeroDePoliza { get; set; }
        public DateTime FechaDeVencimineto { get; set; }
    }
}
