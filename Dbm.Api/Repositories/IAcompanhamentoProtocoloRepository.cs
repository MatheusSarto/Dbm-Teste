using Dbm.Core.Models;

namespace Dbm.Api.Repositories
{
    public interface IAcompanhamentoProtocoloRepository
    {
        Task<ProtocoloFollow> AddAcompanhamentoProtocolo(ProtocoloFollow protocolo);
        Task<ProtocoloFollow?> DeleteAcompanhamentoProtocolo(long idCliente);
        Task<ProtocoloFollow> UpdateAcompanhamentoProtocolo(ProtocoloFollow statusProtocolo);
        Task<ProtocoloFollow> GetStatusAcompanhamentoById(long idAcompanhamento);
        Task<ProtocoloFollow[]> GetTodosstatusProtocolo();
    }
}
