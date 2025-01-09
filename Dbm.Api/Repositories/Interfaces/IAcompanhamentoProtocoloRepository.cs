using Dbm.Core.Models;

namespace Dbm.Api.Repositories.Interfaces
{
    public interface IAcompanhamentoProtocoloRepository
    {
        Task<ProtocoloFollow> AddAcompanhamentoProtocolo(ProtocoloFollow protocolo);
        Task<ProtocoloFollow?> DeleteAcompanhamentoProtocolo(long idCliente);
        Task<ProtocoloFollow> UpdateAcompanhamentoProtocolo(ProtocoloFollow statusProtocolo);
        Task<ProtocoloFollow?> GetAcompanhamentoById(long idAcompanhamento);
        Task<ProtocoloFollow[]> GetTodosAcompanhamentosProtocolo();
    }
}
