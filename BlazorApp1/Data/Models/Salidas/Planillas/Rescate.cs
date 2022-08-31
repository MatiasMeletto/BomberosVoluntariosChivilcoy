namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Rescate : Salida
    {
        //Localización, Datos del solicitante, personas damnificadas y datos del seguro
        public RescatePersona? RescatePersona { get; set; }
        public RescateAnimal? RescateAnimal { get; set; }
    }
}
