using BlazorApp1.Data.Enums;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class RescateAnimal : Rescate
    {
        //CARCTERÍSTICAS DEL LUGAR

        //Tipo de lugar animal

        public TipoRescateAnimal TipoRescateAnimal { get; set; }
    }
}