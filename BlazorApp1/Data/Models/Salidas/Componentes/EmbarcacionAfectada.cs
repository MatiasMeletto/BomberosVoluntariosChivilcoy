using BlazorApp1.Data.Models.Salidas.Planillas;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class EmbarcacionAfectada
    {
        public int EmbarcacionAfectadaId { get; set; }

        public bool Intervinientes { get; set; }
        public int CantidadBarcos { get; set; }
        public int CantidadBotes { get; set; }
        public int CantidadFragatas { get; set; }
        public int CantidadLanchas { get; set; }
        [StringLength(255)]
        public string? Otro { get; set; }

        public int SalidaId { get; set; }
        public Incendio Incendio { get; set; }
    }
}
