namespace BlazorApp1.Data.Models.Personales
{
    public class Movil : Vehiculo
    {
        public string NumeroMovil { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroChasis { get; set; }
        public string Estado { get; set; }

        public List<MovilBombero> Bomberos { get; set; } = new();
    }
}
