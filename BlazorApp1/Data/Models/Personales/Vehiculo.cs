namespace BlazorApp1.Data.Models.Personales
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }
        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
