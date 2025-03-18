using AplicativoNet.Server.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AplicativoNet.Server.Models
{
    public class Triagem : BaseIdentity
    {
        [StringLength(350)]
        public string Sintomas { get; set; }
        public double PressaoArterial { get; set; }
        public double Peso{ get; set; }
        public int EspecialidadeID{ get; set; }
        public double Altura{ get; set; }
    }
}
