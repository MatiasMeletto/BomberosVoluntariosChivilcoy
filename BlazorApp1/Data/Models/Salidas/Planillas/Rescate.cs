namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public class Rescate : Salida
    {
        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }

    }
}
