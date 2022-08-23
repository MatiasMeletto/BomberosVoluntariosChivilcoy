namespace BlazorApp1.Data.Models
{
    public class Accidente
    {
        public int AccidenteId { get; set; }

        public int CantidadVehiculos { get; set; }


        public List<Vehiculo> Vehiculos { get; set; }


        public string CondicionesClimaticas { get; set; }


        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
