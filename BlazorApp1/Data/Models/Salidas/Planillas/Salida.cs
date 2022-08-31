using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public abstract class Salida
    {
        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public string NumeroMovil { get; set; }
        public int KmSalida { get; set; }
        public int KmLlegada { get; set; }
        public int NumeroParte { get; set; }
        public string Descripcion { get; set; }
        public string CalleORuta { get; set; }
        public string NumeroOKilometro { get; set; }
        public string? EntreCalles { get; set; }
        public string? PisoNumero { get; set; }
        public string? Depto { get; set; }
        public bool Urbana { get; set; }
        public bool Rural { get; set; }
        public string NombreSolicitante { get; set; }
        public string ApellidoSolicitante { get; set; }
        public string DniSolicitante { get; set; }
        public string TelefonoSolicitante { get; set; }
        public bool Intervinientes { get; set; }

        public List<Damnificado> Damnificados { get; set; }

        public int SeguroId { get; set; }
        public Seguro Seguro { get; set; }

        public List<Bombero> CuerpoParticipante { get; set; }

        public int PersonaId { get; set; }
        public Bombero Chofer { get; set; }

        //relaciones con bomberos y moviles
        public List<BomberoSalida> Bomberos { get; set; }
        public List<MovilSalida> Moviles { get; set; }

    }
}
