using BlazorApp1.Data.Models.Personales;

namespace BlazorApp1.Data.Models.Salidas
{
    public class Accidente : Salida
    {
        public int CantidadVehiculos { get; set; }


        public List<VehiculoAfectado> VehiculosAfectado { get; set; }


        public string CondicionesClimaticas { get; set; }
    }
}
