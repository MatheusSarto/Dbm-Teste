using Dbm.Api.Data;
using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Repositories
{
    public class AcompanhamentoProtocoloRepository : IAcompanhamentoProtocoloRepository
    {
        private readonly AppDbContext _context;
        public AcompanhamentoProtocoloRepository(AppDbContext context) => _context = context;


        public async Task<ProtocoloFollow> AddAcompanhamentoProtocolo(ProtocoloFollow protocoloFollow)
        {
            var result = _context.ProtocolosFollow.Add(protocoloFollow);
            await _context.SaveChangesAsync();
        
            return result.Entity;
        }

        public async Task<ProtocoloFollow?> DeleteAcompanhamentoProtocolo(long idProtocoloFollow)
        {
            var protocoloFollow = await _context.ProtocolosFollow.FindAsync(idProtocoloFollow);
            if (protocoloFollow == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.ProtocolosFollow.Remove(protocoloFollow);
            await _context.SaveChangesAsync();
            return protocoloFollow;
        }

        public async Task<ProtocoloFollow?> GetAcompanhamentoById(long idAcompanhamento)
        {
            var result = await _context.ProtocolosFollow.FindAsync(idAcompanhamento);

            return result;
        }

        public async Task<ProtocoloFollow[]> GetTodosAcompanhamentosProtocolo()
        {
            var result = await _context.ProtocolosFollow.ToArrayAsync();

            return result;
        }

        public async Task<ProtocoloFollow> UpdateAcompanhamentoProtocolo(ProtocoloFollow statusProtocolo)
        {
            if (await GetAcompanhamentoById(statusProtocolo.IdFollow) == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.ProtocolosFollow.Entry(statusProtocolo).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return statusProtocolo;
        }
    }
}
