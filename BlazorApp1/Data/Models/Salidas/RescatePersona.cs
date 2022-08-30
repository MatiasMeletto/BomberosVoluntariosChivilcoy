namespace BlazorApp1.Data.Models.Salidas
{
    public class RescatePersona : Salida
    {
        //public int LugarId { get; set; }
        //public Lugar Lugar { get; set; }

        //CARCTERÍSTICAS DEL LUGAR

        //Tipo de lugar persona
        public bool? CasaPersona { get; set; }
        public bool? EdificioPersona { get; set; }
        public bool? CentroComercialPersona { get; set; }
        public bool? RioPersona { get; set; }
        public bool? BosquePersona { get; set; }
        public bool? OtroPersona { get; set; }
    }
}
