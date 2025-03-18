using AplicativoNet.Server.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AplicativoNet.Server.Models
{
    public class Atendimento : BaseIdentity
    {
        public int PacienteID { get; set; }
        public int NumeroSequencial { get; set; }
        public int Status { get; set; }
        public DateTime DataHoraChegada { get; set; } 
    }
}
