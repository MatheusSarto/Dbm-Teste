using Dbm.Core.Models;

namespace Dbm.Api.Repositories
{
    public class AcompanhamentoProtocoloRepository : IAcompanhamentoProtocoloRepository
    {
        public Task<ProtocoloFollow> AddAcompanhamentoProtocolo(ProtocoloFollow protocolo)
        {
            throw new NotImplementedException();
        }

        public Task<ProtocoloFollow?> DeleteAcompanhamentoProtocolo(long idCliente)
        {
            throw new NotImplementedException();
        }

        public Task<ProtocoloFollow> GetStatusAcompanhamentoById(long idAcompanhamento)
        {
            throw new NotImplementedException();
        }

        public Task<ProtocoloFollow[]> GetTodosstatusProtocolo()
        {
            throw new NotImplementedException();
        }

        public Task<ProtocoloFollow> UpdateAcompanhamentoProtocolo(ProtocoloFollow statusProtocolo)
        {
            throw new NotImplementedException();
        }
    }
}
