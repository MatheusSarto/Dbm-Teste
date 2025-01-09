using Dbm.Api.Data;
using Dbm.Api.Repositories.Interfaces;
using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context) => _context = context;
        
        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            var result = _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
           
            return result.Entity;
        }

        public async Task<Cliente?> DeleteCliente(long idCliente)
        {
            var cliente = await _context.Clientes.FindAsync(idCliente);
            if (cliente == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente?> GetClienteById(long idCliente)
        {
            var cliente = await _context.Clientes.FindAsync(idCliente);

            return cliente;
        }

        public async Task<Cliente[]> GetTodosClientes()
        {
            var clientes = await _context.Clientes.ToArrayAsync();
            return clientes;
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            if (await GetClienteById(cliente.IdCliente) == null)
            {
                throw new Exception("Nenhum registro encontrado");
            }


            _context.Entry(cliente).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return cliente;
        }
    }
}
