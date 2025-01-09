using Dbm.Api.Repositories;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.Protocolo;

namespace Dbm.Api.Handlers
{
    public class ProtocoloHandler : IProtocoloHandler
    {
        private readonly IProtocolosRepository _protocoloRepository;

        public ProtocoloHandler(IProtocolosRepository protocoloRepository) => _protocoloRepository = protocoloRepository;


        public async Task<Protocolo?> AddProtocolo(AddProtocolo request)
        {
            var novoProtocolo = new Protocolo();
            novoProtocolo.DataAbertura = DateTime.Now;
            novoProtocolo.ClienteId = request.ClienteId;
            novoProtocolo.Titulo = request.Titulo;
            novoProtocolo.Descricao = request.Descricao;
            novoProtocolo.ProtocoloStatusId = request.ProtocoloStatusId;

            var result = await _protocoloRepository.AddProtocolo(novoProtocolo);
            return result;
        }

        public async Task<Protocolo?> DeleteProtocolo(DeleteProtocolo request)
        {
            var result = await _protocoloRepository.DeleteProtocolo(request.IdProtocolo);

            return result;
        }

        public async Task<Protocolo?> GetProtocoloById(GetProtocoloById request)
        {
            var result = await _protocoloRepository.GetProtocoloById(request.IdProtocolo);

            return result;
        }

        public async Task<Protocolo[]> GetTodosProtocolo(GetTodosProtocolos request)
        {
            var result = await _protocoloRepository.GetTodosProtocolo();

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
            return result;
        }
    }
}
