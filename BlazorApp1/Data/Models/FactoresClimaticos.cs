namespace BlazorApp1.Data.Models
{
    public class FactoresClimaticos
    {
        public int FactoresClimaticosId { get; set; }

        public string DatosDaños { get; set; }


        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
