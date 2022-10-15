using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class RescatePersona : Rescate
    {
        //CARCTERÍSTICAS DEL LUGAR

        //Tipo de lugar persona

        public TipoRescatePersona TipoRescatePersona { get; set; }
    }
}
