namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class RescateAnimal : Salida
    {
        //public int LugarId { get; set; }
        //public Lugar Lugar { get; set; }

        //CARCTERÍSTICAS DEL LUGAR

        //Tipo de lugar animal
        public bool? CasaAnimal { get; set; }
        public bool? EdificioAnimal { get; set; }
        public bool? CentroComercialAnimal { get; set; }
        public bool? RioAnimal { get; set; }
        public bool? BosqueAnimal { get; set; }
        public bool? OtroAnimal { get; set; }
    }
}