using BlazorApp1.Data.Models.Salidas.Planillas;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class Seguro
    {
        public int SeguroId { get; set; }

        public string CompañiaAseguradora { get; set; }
        public string NumeroDePoliza { get; set; }
        public DateTime FechaDeVencimineto { get; set; }

        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
