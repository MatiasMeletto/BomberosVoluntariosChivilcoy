namespace BlazorApp1.Data.Models.Personales
{
    public class Bombero : Persona
    {
        public int BomberoId { get; set; }

        public int NumeroLegajo { get; set; }
        public string Estado { get; set; }
        public DateTime FechaAceptacion { get; set; }
        public string Dotacion { get; set; }
        public string Brigada { get; set; }
        public string Resolucion1 { get; set; }
        public string Resolucion2 { get; set; }
        public string Resolucion3 { get; set; }
        public string Resolucion4 { get; set; }
        public string Resolucion5 { get; set; }
        public string Resolucion6 { get; set; }
        public bool Chofer { get; set; }
        public DateTime? VencimientoRegistro { get; set; }

        public List<Vehiculo>? Vehiculos { get; set; } = new();

        public int? MovilId { get; set; }
        public Movil? Movil { get; set; }
    }
}
