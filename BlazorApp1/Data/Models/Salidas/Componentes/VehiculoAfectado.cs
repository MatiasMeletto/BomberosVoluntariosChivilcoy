using BlazorApp1.Data.Models.Personales;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class VehiculoAfectado : Vehiculo
    {
        public bool? Airbag { get; set; }

        public int SalidaId { get; set; }
    }
}
