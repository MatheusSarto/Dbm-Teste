using Dbm.Core.Handlers;
using Dbm.Core.Requests.Protocolo;
using Microsoft.AspNetCore.Mvc;

namespace Dbm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtocoloController : ControllerBase
    {
        private readonly IProtocoloHandler ProtocoloHandler;

        public ProtocoloController(IProtocoloHandler protocoloHandler) => ProtocoloHandler = protocoloHandler;



        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddProtocolo request)
        {
            try
            {
                var result = await ProtocoloHandler.AddProtocolo(request);
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
        public async Task<IActionResult> GetById(GetProtocoloById request)
        {
            try
            {
                var result = await ProtocoloHandler.GetProtocoloById(request);
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
        public async Task<IActionResult> GetAll(GetTodosProtocolos request)
        {
            try
            {
                var result = await ProtocoloHandler.GetTodosProtocolo(request);
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
        public async Task<IActionResult> Update(UpdateProtocolo request)
        {
            try
            {
                var result = await ProtocoloHandler.UpdateProtocolo(request);
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
        public async Task<IActionResult> Delete(DeleteProtocolo request)
        {
            try
            {
                var result = await ProtocoloHandler.DeleteProtocolo(request);
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
