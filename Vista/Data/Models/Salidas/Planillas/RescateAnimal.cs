using Vista.Data.Enums;

namespace Vista.Data.Models.Salidas.Planillas
{
    public class RescateAnimal : Rescate
    {
        //CARCTERÍSTICAS DEL LUGAR

        //Tipo de lugar animal

        public TipoRescateAnimal TipoRescateAnimal { get; set; }
    }
}