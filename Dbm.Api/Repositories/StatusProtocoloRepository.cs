using Dbm.Api.Data;
using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.StatusProtocolos;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Repositories
{
    public class StatusProtocoloRepository : IStatusProtocoloRepository
    {
        private readonly AppDbContext _context;
        public StatusProtocoloRepository(AppDbContext context) => _context = context;


        public async Task<StatusProtocolo> AddStatusProtocolo(StatusProtocolo statusProtocolo)
        {
            var result = _context.StatusProtocolos.Add(statusProtocolo);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<StatusProtocolo?> DeleteStatusProtocolo(long idStatusProtocolo)
        {
            var toDelte = await _context.StatusProtocolos.FindAsync(idStatusProtocolo);
            if (toDelte == null) 
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.StatusProtocolos.Remove(toDelte);
            await _context.SaveChangesAsync();
            return toDelte;
        }

        public async Task<StatusProtocolo?> GetStatusProtocoloById(long idstatusProtocolo)
        {
            var result = await _context.StatusProtocolos.FindAsync(idstatusProtocolo);
            
            return result;
        }

        public async Task<StatusProtocolo[]> GetTodosstatusProtocolo()
        {
            var result = await _context.StatusProtocolos.ToArrayAsync();

            return result;
        }

        public async Task<StatusProtocolo> UpdateStatusProtocolo(StatusProtocolo statusProtocolo)
        {
            if(await GetStatusProtocoloById(statusProtocolo.IdStatus) == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }
            _context.StatusProtocolos.Entry(statusProtocolo).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return statusProtocolo;
        }
    }
}
