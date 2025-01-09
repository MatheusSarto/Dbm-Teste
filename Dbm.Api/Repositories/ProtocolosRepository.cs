using Dbm.Api.Data;
using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Repositories
{
    public class ProtocolosRepository : IProtocolosRepository
    {
        private readonly AppDbContext _context;
        public ProtocolosRepository(AppDbContext context) => _context = context;
        

        public async Task<Protocolo?> AddProtocolo(Protocolo protocolo)
        {
            var novoProtocolo  = _context.Protocolos.Add(protocolo);
            await _context.SaveChangesAsync();
            
            return novoProtocolo.Entity;
        }

        public async Task<Protocolo?> DeleteProtocolo(long idProtocolo)
        {
            var protocolo = await _context.Protocolos.FindAsync(idProtocolo);
            if(protocolo == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.Protocolos.Remove(protocolo);
            await _context.SaveChangesAsync();
            return protocolo;
        }

        public async Task<Protocolo?> GetProtocoloById(long idProtocolo)
        {
            var protocolo = await _context.Protocolos.FindAsync(idProtocolo);

            return protocolo;
        }

        public async Task<Protocolo[]> GetTodosProtocolo()
        {
            return await _context.Protocolos.ToArrayAsync();   
        }

        public async Task<Protocolo?> UpdateProtocolo(Protocolo protocolo)
        {
            if (GetProtocoloById(protocolo.IdProtocolo) == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.Protocolos.Entry(protocolo).State = EntityState.Modified;  
            await _context.SaveChangesAsync();

            return protocolo;
        }
    }
}
