using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.StatusProtocolos
{
    public class UpdateStatusProtocolo : Request
    {
        public long IdStatus { get; set; }
        public string NomeStatus { get; set; } = null!;
    }
}
