namespace BlazorApp1.Data.Models.Personales
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string LugarNacimiento { get; set; }
        public string Documento { get; set; }
        public string GrupoSanguineo { get; set; }
        public string Observaciones { get; set; }
        public string Profesion { get; set; }
        public string NivelEstudios { get; set; }
        public string NumeroIoma { get; set; }

        public int ContactoId { get; set; }
        public Contacto Contacto { get; set; }
    }
}
