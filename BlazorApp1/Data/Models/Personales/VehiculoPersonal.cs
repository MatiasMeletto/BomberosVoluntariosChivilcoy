namespace BlazorApp1.Data.Models.Personales
{
    public class VehiculoPersonal : Vehiculo
    {
        public int BomberoId { get; set; }
        public Bombero Bombero { get; set; }
    }
}
