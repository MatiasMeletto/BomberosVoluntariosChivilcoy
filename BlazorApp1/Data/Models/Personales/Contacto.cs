using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Data.Models.Personales
{
    public class Contacto
    {
        [StringLength(255)]
        public int ContactoId { get; set; }
        [StringLength(255)]
        public string? TelefonoCel { get; set; }
        [StringLength(255)]
        public string? TelefonoLaboral { get; set; }
        [StringLength(255)]
        public string? TelefonoFijo { get; set; }
        [StringLength(255)]
        public string? Email { get; set; }

        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
    }
}
