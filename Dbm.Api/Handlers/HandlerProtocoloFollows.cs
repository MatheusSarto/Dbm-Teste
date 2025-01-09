using Dbm.Api.Repositories;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.ProtocoloFollow;
using Microsoft.AspNetCore.Server.HttpSys;

namespace Dbm.Api.Handlers
{
    public class HandlerProtocoloFollows : IHandlerProtocoloFollow
    {
        private IAcompanhamentoProtocoloRepository _protocoloFollowRepository;
        public HandlerProtocoloFollows(IAcompanhamentoProtocoloRepository protocoloFollowRepository)
            => _protocoloFollowRepository = protocoloFollowRepository;

        public async Task<ProtocoloFollow?> AddProtocoloFollow(AddProtocoloFollow request)
        {
            var novoProtocoloFollow = new ProtocoloFollow();
            novoProtocoloFollow.ProtocoloId = request.ProtocoloId;
            novoProtocoloFollow.ProtocoloId = request.ProtocoloId;
            novoProtocoloFollow.DataAcao = DateTime.Now;
            novoProtocoloFollow.DescricaoAcao = request.DescricaoAcao;

            await _protocoloFollowRepository.AddAcompanhamentoProtocolo(novoProtocoloFollow);
            
            return novoProtocoloFollow; 
        }

        public async Task<ProtocoloFollow?> DeleteProtocoloFollow(DeleteProtocoloFollow request)
        {
            var result = await _protocoloFollowRepository.DeleteAcompanhamentoProtocolo(request.ProtocoloId);
            
            return result;
        }

        public async Task<ProtocoloFollow?> GetProtocoloFollowById(GetProtocoloFollowById request)
        {
            var result = await _protocoloFollowRepository.GetAcompanhamentoById(request.ProtocoloId);

            return result;
        }

        public async Task<ProtocoloFollow[]> GetTodosProtocolosFollow(GetTodosProtocolosFollow request)
        {
            var result = await _protocoloFollowRepository.GetTodosAcompanhamentosProtocolo();

            return result;
        }

        public async Task<ProtocoloFollow?> UpdateProtocoloFollow(UpdateProtocoloFollow request)
        {
            var updateProtocolo = new ProtocoloFollow();
            updateProtocolo.IdFollow = request.IdFollow;
            updateProtocolo.ProtocoloId = request.ProtocoloId;
            updateProtocolo.DataAcao = DateTime.Now;
            updateProtocolo.DescricaoAcao = request.DescricaoAcao;

            var result = await _protocoloFollowRepository.UpdateAcompanhamentoProtocolo(updateProtocolo);

            return result;
        }
    }
}
