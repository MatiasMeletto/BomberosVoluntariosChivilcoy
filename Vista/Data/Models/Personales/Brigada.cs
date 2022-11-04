namespace Vista.Data.Models.Personales
{
    public class Brigada
    {
        public int BrigadaId { get; set; }
        public string Nombre { get; set; }
        public List<Bombero> Bomberos { get; set; }
        
    }
}
