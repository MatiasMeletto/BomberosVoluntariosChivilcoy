using BlazorApp1.Data.Models.Personales;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class VehiculoDamnificado : Vehiculo
    {
        public string Color { get; set; }
        public bool? Airbag { get; set; }

        public int DamnificadoId { get; set; }
        public Damnificado Damnificado { get; set; }

        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }
    }
}
