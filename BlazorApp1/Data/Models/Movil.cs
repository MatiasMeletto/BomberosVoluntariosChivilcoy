namespace BlazorApp1.Data.Models
{
    public class Movil
    {
        public string NroMovil { get; set; }
        public string NroMotor { get; set; }
        public string NroChasis { get; set; }
        public string Encargado { get; set; }
        public string Estado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }
        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
