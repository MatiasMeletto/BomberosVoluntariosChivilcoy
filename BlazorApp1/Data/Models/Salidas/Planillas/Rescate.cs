using System.ComponentModel.DataAnnotations;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class Rescate : Salida
    {
        //Localización, Datos del solicitante, personas damnificadas y datos del seguro
        [Required, StringLength(255)]
        public string Otro { get; set; }
    }
}
