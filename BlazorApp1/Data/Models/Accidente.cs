namespace BlazorApp1.Data.Models
{
    public class Accidente : Salida
    {
        public int AccidenteId { get; set; }

        public int CantidadVehiculos { get; set; }


        public List<Vehiculo> Vehiculos { get; set; }


        public string CondicionesClimaticas { get; set; }
    }
}
