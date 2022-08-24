namespace BlazorApp1.Data.Models.Personales
{
    public class Movil
    {
        public int MovilId { get; set; }

        public string NumeroMovil { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public string Estado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }

        public int? BomberoId { get; set; }
        public Bombero? Encargado { get; set; }

        public List<Bombero>? Subalternos { get; set; } = new();
    }
}
