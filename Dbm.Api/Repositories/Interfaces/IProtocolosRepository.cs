using Dbm.Core.Models;

namespace Dbm.Api.Repositories.Interfaces
{
    public interface IProtocolosRepository
    {
        Task<Protocolo?> AddProtocolo(Protocolo protocolo);
        Task<Protocolo?> DeleteProtocolo(long idProtocolo);
        Task<Protocolo?> UpdateProtocolo(Protocolo protocolo);
        Task<Protocolo?> GetProtocoloById(long idProtocolo);
        Task<Protocolo[]> GetTodosProtocolo();
    }
}
