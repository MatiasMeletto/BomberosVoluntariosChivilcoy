namespace BlazorApp1.Data.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public int BomberoId { get; set; }
        public  Bombero Bombero { get; set; }       
        public string? TelefonoCel { get; set; }
        public string? TelefonoLaboral { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Email { get; set; }
    }
}
