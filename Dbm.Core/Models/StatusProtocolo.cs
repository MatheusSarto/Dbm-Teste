using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Models
{
    public class StatusProtocolo
    {
        public long IdStatus { get; set; }
        public string NomeStatus { get; set; } = null!;

        public ICollection<Protocolo> Protocolos { get; set; }
    }
}
