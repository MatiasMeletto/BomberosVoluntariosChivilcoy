using BlazorApp1.Data.Models.Salidas.Planillas;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class EmbarcacionAfectada
    {
        public int EmbarcacionAfectadaId { get; set; }

        public bool Intervinientes { get; set; }
        public string CantidadBarcos { get; set; }
        public string CantidadBotes { get; set; }
        public string CantidadFragatas { get; set; }
        public string CantidadLanchas { get; set; }
        public string Otro { get; set; }

        public int SalidaId { get; set; }
        public Incendio Incendio { get; set; }
    }
}
