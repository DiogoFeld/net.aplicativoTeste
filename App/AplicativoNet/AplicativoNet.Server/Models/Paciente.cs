using AplicativoNet.Server.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace AplicativoNet.Server.Models
{
    public class Paciente : BaseIdentity
    {
        [StringLength(50)]
        public string Nome { get; set; }
        [StringLength(15)]
        public string Sexo { get; set; }

        [StringLength(40)]
        public string Email { get; set; }
        public int Telefone { get; set; }
    }
}
