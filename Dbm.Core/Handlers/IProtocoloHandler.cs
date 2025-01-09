using Dbm.Core.Models;
using Dbm.Core.Requests;
using Dbm.Core.Requests.Protocolo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Handlers
{
    public interface IProtocoloHandler
    {
        Task<Protocolo?> AddProtocolo(AddProtocolo request);
        Task<Protocolo?> DeleteProtocolo(DeleteProtocolo request);
        Task<Protocolo?> UpdateProtocolo(UpdateProtocolo request);
        Task<Protocolo?> GetProtocoloById(GetProtocoloById request);
        Task<Protocolo[]> GetTodosProtocolo(GetTodosProtocolos request);
    }
}
