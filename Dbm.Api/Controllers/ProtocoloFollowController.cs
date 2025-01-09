using Dbm.Core.Handlers;
using Dbm.Core.Requests.Cliente;
using Dbm.Core.Requests.Protocolo;
using Dbm.Core.Requests.ProtocoloFollow;
using Microsoft.AspNetCore.Mvc;

namespace Dbm.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProtocoloFollowController : ControllerBase
    {
        private readonly IHandlerProtocoloFollow ProtocoloFollowHandler;

        public ProtocoloFollowController(IHandlerProtocoloFollow handlerProtocoloFollow) => ProtocoloFollowHandler = handlerProtocoloFollow;


        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddProtocoloFollow request)
        {
            try
            {
                var result = await ProtocoloFollowHandler.AddProtocoloFollow(request);
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
        public async Task<IActionResult> GetById(GetProtocoloFollowById request)
        {
            try
            {
                var result = await ProtocoloFollowHandler.GetProtocoloFollowById(request);
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
        public async Task<IActionResult> GetAll(GetTodosProtocolosFollow request)
        {
            try
            {
                var result = await ProtocoloFollowHandler.GetTodosProtocolosFollow(request);
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
        public async Task<IActionResult> Update(UpdateProtocoloFollow request)
        {
            try
            {
                var result = await ProtocoloFollowHandler.UpdateProtocoloFollow(request);
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
        public async Task<IActionResult> Delete(DeleteProtocoloFollow request)
        {
            try
            {
                var result = await ProtocoloFollowHandler.DeleteProtocoloFollow(request);
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
