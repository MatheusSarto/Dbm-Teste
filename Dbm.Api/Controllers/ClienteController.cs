using Dbm.Api.Handlers;
using Dbm.Core.Handlers;
using Dbm.Core.Models;
using Dbm.Core.Requests.Cliente;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dbm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IHandlerCliente ClienteHandler;
        
        public ClienteController(IHandlerCliente clienteHandler) 
        {
            ClienteHandler = clienteHandler;
        }


        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddCliente request)
        {
            try
            {
                var result = await ClienteHandler.AddCliente(request);
                if (result != null)
                {
                    return Ok(result);
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("GetById")]
        public async Task<IActionResult> GetById(GetClienteById request)
        {
            try
            {
                var result = await ClienteHandler.GetClienteById(request);
                if (result != null)
                {
                    return Ok(result);
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll(GetTodosClientes request)
        {
            try
            {
                var result = await ClienteHandler.GetTodosClientes(request);
                if (result != null)
                {
                    return Ok(result);
                }
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Update")]
        public async Task<IActionResult> Update(UpdateCliente request)
        {
            try
            {
                var result = await ClienteHandler.UpdateCliente(request);
                if (result != null)
                {
                    return Ok(result);
                }
                return NoContent();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Delete")]
        public async Task<IActionResult> Delete(DeleteCliente request)
        {
            try
            {
                var result = await ClienteHandler.DeleteCliente(request);
                if (result != null)
                {
                    return Ok(result);
                }
                return NoContent();

            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
