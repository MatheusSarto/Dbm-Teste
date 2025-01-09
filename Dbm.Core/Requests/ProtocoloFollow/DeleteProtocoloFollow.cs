using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.ProtocoloFollow
{
    public class DeleteProtocoloFollow : Request
    {
        public long ProtocoloId { get; set; }
    }
}
