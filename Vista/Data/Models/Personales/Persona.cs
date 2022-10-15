using Vista.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Personales
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public TipoSexo Sexo { get; set; }
        [Required, StringLength(255)]
        public string Nombre { get; set; }
        [Required, StringLength(255)]
        public string Apellido { get; set; }
        [Required, StringLength(255)]
        public string Direccion { get; set; }
        [Required, StringLength(255)]
        public string LugarNacimiento { get; set; }
        [Required, StringLength(255)]
        public string Documento { get; set; }
        [Required, StringLength(255)]
        public string GrupoSanguineo { get; set; }
        [Required, StringLength(255)]
        public string Observaciones { get; set; }
        [Required, StringLength(255)]
        public string Profesion { get; set; }
        [Required, StringLength(255)]
        public string NivelEstudios { get; set; }
        [Required, StringLength(255)]
        public string NumeroIoma { get; set; }

        public Contacto Contacto { get; set; }
    }
}
