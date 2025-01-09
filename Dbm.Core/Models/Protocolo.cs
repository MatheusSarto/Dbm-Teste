using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Models
{
    public class Protocolo
    {
        public long IdProtocolo { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public DateTime? DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        public long ClienteId { get; set; }
        public long ProtocoloStatusId { get; set; }

        public Cliente Cliente { get; set; }
        public StatusProtocolo ProtocoloStatus { get; set; }
        public ICollection<ProtocoloFollow> ProtocoloFollows { get; set; } 
    }
}
