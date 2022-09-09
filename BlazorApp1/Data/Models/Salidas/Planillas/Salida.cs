using BlazorApp1.Data.Enums;
using BlazorApp1.Data.Models.Personales;
using BlazorApp1.Data.Models.Salidas.Componentes;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas.Planillas
{
    public abstract class Salida
    {
        public int SalidaId { get; set; }

        public DateTime Fecha { get; set; }
        public DateTime HoraSalida { get; set; }
        public DateTime HoraLlegada { get; set; }
        public int KmSalida { get; set; }
        public int KmLlegada { get; set; }
        public int NumeroParte { get; set; }
        public string Descripcion { get; set; }
        public string CalleORuta { get; set; }
        public string NumeroOKilometro { get; set; }
        public string? EntreCalles { get; set; }
        public string? PisoNumero { get; set; }
        public string? Depto { get; set; }
        public TipoZona TipoZona { get; set; }
        public string NombreSolicitante { get; set; }
        public string ApellidoSolicitante { get; set; }
        public string DniSolicitante { get; set; }
        public string TelefonoSolicitante { get; set; }

        public string? Receptor { get; set; }

        public int? ReceptorId { get; set; }

        [ForeignKey("ReceptorId")]
        public Bombero? ReceptorBombero { get; set; }

        //Si hay damnificados, entonces hay intervinientes
        public List<Damnificado> Damnificados { get; set; }

        public Seguro Seguro { get; set; }

        //relaciones con bomberos y moviles
        public List<MovilSalida> Moviles { get; set; }
        
        public List<BomberoSalida> CuerpoParticipante { get; set; }

        public int EncargadoId { get; set; }
        [ForeignKey("EncargadoId")]
        public Bombero Encargado { get; set; }

        public int QuienLlenoId { get; set; }
        [ForeignKey("QuienLlenoId")]
        public Bombero QuienLleno { get; set; }
    }
}
