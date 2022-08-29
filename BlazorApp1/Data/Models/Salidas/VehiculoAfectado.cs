namespace BlazorApp1.Data.Models.Salidas
{
    public abstract class VehiculoAfectado
    {
        public int VehiculoAfectadoId { get; set; }

        public string Marca { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public string Año { get; set; }
        public string Aseguradora { get; set; }
        public string Poliza { get; set; }
        public bool? Airbag { get; set; }

        public int SalidaId { get; set; }
    }
}
