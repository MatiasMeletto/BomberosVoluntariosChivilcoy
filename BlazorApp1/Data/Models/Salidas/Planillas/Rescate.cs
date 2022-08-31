using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Rescate : Salida
    {
        //Localización, Datos del solicitante, personas damnificadas y datos del seguro
        public TipoRescate Tipo { get; set; }
    }
}
