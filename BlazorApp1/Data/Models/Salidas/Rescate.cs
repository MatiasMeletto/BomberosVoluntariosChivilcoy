namespace BlazorApp1.Data.Models.Salidas
{
    public class Rescate : Salida
    {
        public int RescateId { get; set; }


        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }

    }
}
