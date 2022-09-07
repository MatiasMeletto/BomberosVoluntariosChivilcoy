namespace BlazorApp1.Data.Models.Personales
{
    public class Contacto
    {
        public int ContactoId { get; set; }

        public string? TelefonoCel { get; set; }
        public string? TelefonoLaboral { get; set; }
        public string? TelefonoFijo { get; set; }
        public string? Email { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
