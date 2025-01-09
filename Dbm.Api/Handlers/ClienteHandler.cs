using Dbm.Api.Data;
using Dbm.Api.Repositories.Interfaces;
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

        private IClienteRepository _clienteRepository;
        public ClienteHandler(IClienteRepository clienteRepository) => _clienteRepository = clienteRepository;


        public async Task<Cliente> AddCliente(AddCliente request)
        {
            var novoCliente = new Cliente(); 
            novoCliente.Telefone = request.Telefone;
            novoCliente.Nome = request.Nome;
            novoCliente.Email = request.Email;
            novoCliente.Endereco = request.Endereco;

            var result = await _clienteRepository.AddCliente(novoCliente);
            return result;
        }

        public async Task<Cliente?> DeleteCliente(DeleteCliente request)
        {
            var result = await _clienteRepository.DeleteCliente(request.IdCliente);
            return result;
        }

        public async Task<Cliente> GetClienteById(GetClienteById request)
        {
            var result = await _clienteRepository.GetClienteById(request.ClienteId);
            return result;
        }

        public async Task<Cliente[]> GetTodosClientes(GetTodosClientes request)
        {
            var result = await _clienteRepository.GetTodosClientes();
            return result;
        }

        public async Task<Cliente> UpdateCliente(UpdateCliente request)
        {
           var updateCliente = new Cliente();
            updateCliente.Telefone = request.Telefone;
            updateCliente.Nome = request.Nome;
            updateCliente.Email = request.Email;
            updateCliente.IdCliente = request.ClienteId;
            updateCliente.Endereco = request.Endereco;

            var result = await _clienteRepository.UpdateCliente(updateCliente);
            return result;
        }
    }
}
