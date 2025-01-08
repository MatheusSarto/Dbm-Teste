using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.Cliente
{
    public class GetClienteById : Request
    {
        public long ClienteId { get; set; } 
    }
}
