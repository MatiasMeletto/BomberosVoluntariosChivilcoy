using BlazorApp1.Data.Models.Personales;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public abstract class VehiculoAfectado : Vehiculo
    {
        public bool? Airbag { get; set; }

        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        public int SalidaId { get; set; }
    }
}
