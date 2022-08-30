using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Personales
{
    public class VehiculoPersonal : Vehiculo
    {
        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
