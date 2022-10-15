using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Personales
{
    public abstract class Imagen
    {
        public int ImagenId { get; set; }

        [Required, StringLength(255)]
        public string NombreImagen { get; set; }
        public string Base64Imagen { get; set; }
        [Required, StringLength(255)]
        public string TipoImagen { get; set; }
    }
}
