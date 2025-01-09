using Dbm.Core.Models;
using Dbm.Core.Requests.Protocolo;
using Dbm.Core.Requests.StatusProtocolos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Handlers
{
    public interface IStatusProtocolo
    {
        Task<StatusProtocolo?> AddStatusProtocolo(AddStatusProtocolo request);
        Task<StatusProtocolo?> DeleteStatusProtocolo(DeleteStatusProtocolo request);
        Task<StatusProtocolo?> UpdateStatusProtocolo(UpdateStatusProtocolo request);
        Task<StatusProtocolo?> GetStatusProtocoloById(GetStatusProtocoloById request);
        Task<StatusProtocolo[]> GetTodosStatusProtocolo(GetTodosStatusProtocolo request);
    }
}
