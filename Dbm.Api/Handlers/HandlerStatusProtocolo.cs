using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.StatusProtocolos;

namespace Dbm.Api.Handlers
{
    public class HandlerStatusProtocolo : IStatusProtocolo
    {
        private readonly IStatusProtocoloRepository _statusProtocoloRepository;
        public HandlerStatusProtocolo(IStatusProtocoloRepository statusProtocoloRepository) 
            => _statusProtocoloRepository = statusProtocoloRepository;

        public async Task<StatusProtocolo?> AddStatusProtocolo(AddStatusProtocolo request)
        {
            var novoProtocolo = new StatusProtocolo();
            novoProtocolo.NomeStatus = request.NomeStatus;

            var result = await _statusProtocoloRepository.AddStatusProtocolo(novoProtocolo);
            return result;
        }

        public async Task<StatusProtocolo?> DeleteStatusProtocolo(DeleteStatusProtocolo request)
        {
            var result = await _statusProtocoloRepository.DeleteStatusProtocolo(request.IdStatus);

            return result;
        }

        public async Task<StatusProtocolo?> GetStatusProtocoloById(GetStatusProtocoloById request)
        {
            var result = await _statusProtocoloRepository.GetStatusProtocoloById(request.IdStatus);

            return result;
        }

        public async Task<StatusProtocolo[]> GetTodosStatusProtocolo(GetTodosStatusProtocolo request)
        {
            var result = await _statusProtocoloRepository.GetTodosstatusProtocolo();

            return result;
        }

        public async Task<StatusProtocolo?> UpdateStatusProtocolo(UpdateStatusProtocolo request)
        {
            var updateStatusProtocolo = new StatusProtocolo();
            updateStatusProtocolo.NomeStatus = request.NomeStatus;
            updateStatusProtocolo.IdStatus = request.IdStatus;

            var result = await _statusProtocoloRepository.UpdateStatusProtocolo(updateStatusProtocolo);
            return result;
        }
    }
}
