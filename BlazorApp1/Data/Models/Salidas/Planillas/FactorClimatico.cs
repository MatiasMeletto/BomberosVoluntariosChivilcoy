namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class FactorClimatico : Salida
    {
        //Daños superficie evacuada
        public bool? Evacuó { get; set; }
        public int Kilometros { get; set; }
        public int Hectareas { get; set; }
        public int Metros { get; set; }
        public string DetalleSuperficieDañada { get; set; }

    }
}
