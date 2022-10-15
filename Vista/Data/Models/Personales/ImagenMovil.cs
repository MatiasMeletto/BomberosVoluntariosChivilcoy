using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Personales
{
    public class ImagenMovil : Imagen
    {
        public Movil Movil { get; set; }
    }
}
