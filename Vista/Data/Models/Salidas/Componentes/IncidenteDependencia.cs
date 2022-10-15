using Vista.Data.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vista.Data.Models.Salidas.Componentes
{
    public class IncidenteDependencia : Incidente
    {
        public int DependenciaId { get;set; }
        public Dependencia Dependencia { get;set; }
    }
}
