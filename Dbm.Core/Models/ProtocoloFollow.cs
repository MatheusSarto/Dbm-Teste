using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Models
{
    public class ProtocoloFollow
    {
        public long IdFollow { get; set; }
        public long ProtocoloId { get; set; }
        public DateTime DataAcao { get; set; }
        public string DescricaoAcao { get; set; } = null!;

        public Protocolo Protocolo { get; set; }
    }
}
