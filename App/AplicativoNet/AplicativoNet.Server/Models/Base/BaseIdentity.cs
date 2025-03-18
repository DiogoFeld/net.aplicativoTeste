using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AplicativoNet.Server.Models.Base
{
    public class BaseIdentity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
    }
}
