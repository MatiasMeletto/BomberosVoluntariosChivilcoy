using BlazorApp1.Data.Models.Salidas.Planillas;

namespace BlazorApp1.Data.Models.Personales
{
    public class MovilSalida
    {
        public int MovilSalidaId { get; set; }

        public int PersonaId { get; set; }
        public Bombero Chofer { get; set; }

        public int MovilId { get; set; }
        public Movil Movil { get; set; }

        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
