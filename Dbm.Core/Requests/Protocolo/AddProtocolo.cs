using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.Protocolo
{
    public class AddProtocolo : Request
    {
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public DateTime? DataFechamento { get; set; }

        public long ClienteId { get; set; }
        public long ProtocoloStatusId { get; set; }
    }
}
