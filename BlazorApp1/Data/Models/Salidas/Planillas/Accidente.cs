using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Accidente : Salida
    {
        //Localización, datos del solicitante, personas damnificadas y datos del seguro

        public int CantidadVehiculos { get; set; }


        public List<VehiculoAfectado> VehiculosAfectado { get; set; }


        public string CondicionesClimaticas { get; set; }
    }
}
