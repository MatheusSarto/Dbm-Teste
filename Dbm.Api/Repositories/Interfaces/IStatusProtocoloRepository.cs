using Dbm.Core.Models;

namespace Dbm.Api.Repositories.Interfaces
{
    public interface IStatusProtocoloRepository
    {
        Task<StatusProtocolo> AddStatusProtocolo(StatusProtocolo statusProtocolo);
        Task<StatusProtocolo?> DeleteStatusProtocolo(long idStatusProtocolo);
        Task<StatusProtocolo> UpdateStatusProtocolo(StatusProtocolo statusProtocolo);
        Task<StatusProtocolo> GetStatusProtocoloById(long idstatusProtocolo);
        Task<StatusProtocolo[]> GetTodosstatusProtocolo();
    }
}
