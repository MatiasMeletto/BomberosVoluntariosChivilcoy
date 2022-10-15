using BlazorApp1.Data.Models.Personales;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp1.Data.Models.Salidas.Componentes
{
    public class IncidenteDependencia : Incidente
    {
        public int DependenciaId { get;set; }
        public Dependencia Dependencia { get;set; }
    }
}
