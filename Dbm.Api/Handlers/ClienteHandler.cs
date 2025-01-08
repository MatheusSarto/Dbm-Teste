using Dbm.Api.Data;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Dbm.Core.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Handlers
{
    public class ClienteHandler : IHandlerCliente
    {
        private readonly AppDbContext _context;
        public ClienteHandler(AppDbContext context) 
        {
            _context = context;
        }
        public async Task<Cliente> AddCliente(AddCliente request)
        {
            var novoCliente = new Cliente(); 
            novoCliente.Telefone = request.Telefone;
            novoCliente.Nome = request.Nome;
            novoCliente.Email = request.Email;
            novoCliente.Endereco = request.Endereco;

            _context.Clientes.Add(novoCliente);
            await _context.SaveChangesAsync(); 
            
            return novoCliente;
        }

        public async Task<Cliente?> DeleteCliente(DeleteCliente request)
        {
            var cliente = await _context.Clientes.FindAsync(request.IdCliente);
            if(cliente != null)
            {
                _context.Clientes.Remove(cliente); 
                await _context.SaveChangesAsync();  
            }

            return cliente;
        }

        public async Task<Cliente> GetClienteById(GetClienteById request)
        {
            var cliente = await _context.Clientes.FindAsync(request.ClienteId);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }

            return cliente;
        }

        public async Task<Cliente[]> GetTodosClientes(GetTodosClientes request)
        {
            var clientes = await _context.Clientes.ToArrayAsync();
            return clientes;
        }

        public async Task<Cliente> UpdateCliente(UpdateCliente request)
        {
           var updateCliente = new Cliente();
            updateCliente.Telefone = request.Telefone;
            updateCliente.Nome = request.Nome;
            updateCliente.Email = request.Email;
            updateCliente.IdCliente = request.ClienteId;
            updateCliente.Endereco = request.Endereco;  
            
            _context.Entry(updateCliente).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return updateCliente;
        
        }
    }
}
