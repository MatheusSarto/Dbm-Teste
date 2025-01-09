using Dbm.Core.Models;
using Dbm.Core.Requests.Protocolo;
using Dbm.Core.Requests.ProtocoloFollow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Handlers
{
    public interface IHandlerProtocoloFollow
    {
        Task<ProtocoloFollow?> AddProtocoloFollow(AddProtocoloFollow request);
        Task<ProtocoloFollow?> DeleteProtocoloFollow(DeleteProtocoloFollow request);
        Task<ProtocoloFollow?> UpdateProtocoloFollow(UpdateProtocoloFollow request);
        Task<ProtocoloFollow?> GetProtocoloFollowById(GetProtocoloFollowById request);
        Task<ProtocoloFollow[]> GetTodosProtocolosFollow(GetTodosProtocolosFollow request);
    }
}
