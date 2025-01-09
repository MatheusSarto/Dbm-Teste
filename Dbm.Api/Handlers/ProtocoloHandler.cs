using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.Protocolo;

namespace Dbm.Api.Handlers
{
    public class ProtocoloHandler : IProtocoloHandler
    {
        public Task<Protocolo?> AddProtocolo(AddProtocolo request)
        {
            throw new NotImplementedException();
        }

        public Task<Protocolo?> DeleteProtocolo(DeleteProtocolo request)
        {
            throw new NotImplementedException();
        }

        public Task<Protocolo?> GetProtocoloById(GetProtocoloById request)
        {
            throw new NotImplementedException();
        }

        public Task<Protocolo[]> GetTodosProtocolo(GetTodosProtocolos request)
        {
            throw new NotImplementedException();
        }

        public Task<Protocolo?> UpdateProtocolo(UpdateProtocolo request)
        {
            throw new NotImplementedException();
        }
    }
}
