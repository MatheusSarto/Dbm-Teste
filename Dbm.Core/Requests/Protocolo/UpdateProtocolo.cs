using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.Protocolo
{
    public class UpdateProtocolo : Request
    {
        public long IdProtocolo { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }

        public long ClienteId { get; set; }
        public long ProtocoloStatusId { get; set; }
    }
}
