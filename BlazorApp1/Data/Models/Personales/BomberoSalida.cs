using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Salidas.Planillas;

namespace BlazorApp1.Data.Models.Personales
{
    public class BomberoSalida
    {
        public int BomberoSalidaId { get; set; }

        public bool Salio { get; set; }
        public EscalafonJerarquico Grado { get; set; }

        public int PersonaId { get; set; }
        public Bombero Bombero { get; set; }

        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
