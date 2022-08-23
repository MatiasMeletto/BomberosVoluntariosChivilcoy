namespace BlazorApp1.Data.Models
{
    public class Rescate
    {
        public int RescateId { get; set; }


        public int LugarId { get; set; }
        public Lugar Lugar { get; set; }
         
        public int SalidaId { get; set; }
        public Salida Salida { get; set; }
    }
}
