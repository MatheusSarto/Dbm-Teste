using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Dbm.Core.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Handlers
{
    public interface IHandlerCliente
    {
        Task<Cliente> AddCliente(AddCliente request);
        Task<Cliente?> DeleteCliente(DeleteCliente request);
        Task<Cliente> UpdateCliente(UpdateCliente request);
        Task<Cliente> GetClienteById(GetClienteById request);
        Task<Cliente[]> GetTodosClientes(GetTodosClientes request);
    }
}
