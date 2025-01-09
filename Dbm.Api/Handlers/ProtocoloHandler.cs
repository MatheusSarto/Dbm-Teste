using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.Protocolo;
using Dbm.Core.Requests.ProtocoloFollow;

namespace Dbm.Api.Handlers
{
    public class ProtocoloHandler : IProtocoloHandler
    {
        private readonly IProtocolosRepository _protocoloRepository;
        private readonly IHandlerProtocoloFollow _handlerProtocoloFollow;

        public ProtocoloHandler(IProtocolosRepository protocoloRepository, IHandlerProtocoloFollow handlerProtocoloFollow)
            => (_protocoloRepository, _handlerProtocoloFollow) = (protocoloRepository, handlerProtocoloFollow); 


        public async Task<Protocolo?> AddProtocolo(AddProtocolo request)
        {
            var novoProtocolo = new Protocolo();
            novoProtocolo.DataAbertura = DateTime.Now;
            novoProtocolo.DataFechamento = request.DataFechamento;
            novoProtocolo.ClienteId = request.ClienteId;
            novoProtocolo.Titulo = request.Titulo;
            novoProtocolo.Descricao = request.Descricao;
            novoProtocolo.ProtocoloStatusId = request.ProtocoloStatusId;

            var result = await _protocoloRepository.AddProtocolo(novoProtocolo);
            if(result != null)
            {
                var follow = new AddProtocoloFollow();
                follow.ProtocoloId = result.IdProtocolo;
                follow.DescricaoAcao = "Protocolo criado";

                await _handlerProtocoloFollow.AddProtocoloFollow(follow);
            }

            return result;
        }

        public async Task<Protocolo?> DeleteProtocolo(DeleteProtocolo request)
        {
            var result = await _protocoloRepository.DeleteProtocolo(request.IdProtocolo);

            if (result != null)
            {
                var follow = new AddProtocoloFollow();
                follow.ProtocoloId = result.IdProtocolo;
                follow.DescricaoAcao = "Protocolo Removido";

                await _handlerProtocoloFollow.AddProtocoloFollow(follow);
            }

            return result;
        }

        public async Task<Protocolo?> GetProtocoloById(GetProtocoloById request)
        {
            var result = await _protocoloRepository.GetProtocoloById(request.IdProtocolo);

            if (result != null)
            {
                var follow = new AddProtocoloFollow();
                follow.ProtocoloId = result.IdProtocolo;
                follow.DescricaoAcao = "Protocolo Consultado";

                await _handlerProtocoloFollow.AddProtocoloFollow(follow);
            }

            return result;
        }

        public async Task<Protocolo[]> GetTodosProtocolo(GetTodosProtocolos request)
        {
            var result = await _protocoloRepository.GetTodosProtocolo();

            if (result != null)
            {
                foreach (var item in result)
                {
                    var follow = new AddProtocoloFollow();
                    follow.ProtocoloId = item.IdProtocolo;
                    follow.DescricaoAcao = "Protocolo criado";

                    await _handlerProtocoloFollow.AddProtocoloFollow(follow);
                }
            }

            return result;
        }

        public async Task<Protocolo?> UpdateProtocolo(UpdateProtocolo request)
        {
            var novoProtocolo = new Protocolo();
            novoProtocolo.ClienteId = request.ClienteId;
            novoProtocolo.Titulo = request.Titulo;
            novoProtocolo.DataFechamento = request.DataFechamento;
            novoProtocolo.Descricao = request.Descricao;
            novoProtocolo.ProtocoloStatusId = request.ProtocoloStatusId;

            var result = await _protocoloRepository.UpdateProtocolo(novoProtocolo);

            if (result != null)
            {
                var follow = new AddProtocoloFollow();
                follow.ProtocoloId = result.IdProtocolo;
                follow.DescricaoAcao = "Protocolo Atualizado";

                await _handlerProtocoloFollow.AddProtocoloFollow(follow);
            }

            return result;
        }
    }
}
