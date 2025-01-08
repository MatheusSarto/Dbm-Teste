using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;

namespace Dbm.Api.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> AddCliente(Cliente cliente);
        Task<Cliente?> DeleteCliente(long idCliente);
        Task<Cliente> UpdateCliente(Cliente cliente);
        Task<Cliente> GetClienteById(long idCliente);
        Task<Cliente[]> GetTodosClientes();
    }
}
