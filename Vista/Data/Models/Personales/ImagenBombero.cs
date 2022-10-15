using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Personales
{
    public class ImagenBombero : Imagen
    {
        public Bombero Bombero { get; set; }
    }
}
