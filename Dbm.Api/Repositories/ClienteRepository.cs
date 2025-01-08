﻿using Dbm.Api.Data;
using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Microsoft.EntityFrameworkCore;

namespace Dbm.Api.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
           
            return cliente;
        }

        public async Task<Cliente?> DeleteCliente(long idCliente)
        {
            var cliente = await _context.Clientes.FindAsync(idCliente);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }

            return cliente;
        }

        public async Task<Cliente> GetClienteById(long idCliente)
        {
            var cliente = await _context.Clientes.FindAsync(idCliente);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }

            return cliente;
        }

        public async Task<Cliente[]> GetTodosClientes()
        {
            var clientes = await _context.Clientes.ToArrayAsync();
            return clientes;
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;

            await _context.SaveChangesAsync();
            return cliente;
        }
    }
}
