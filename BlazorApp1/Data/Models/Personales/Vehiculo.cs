namespace BlazorApp1.Data.Models.Personales
{
    public abstract class Vehiculo
    {
        public int VehiculoId { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }
    }
}
