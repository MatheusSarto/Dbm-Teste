using Dbm.Core.Handlers;
using Dbm.Core.Requests.Protocolo;
using Dbm.Core.Requests.StatusProtocolos;
using Microsoft.AspNetCore.Mvc;

namespace Dbm.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusProtocoloController : ControllerBase
    {
        private readonly IStatusProtocolo StatusProtocoloHandler;

        public StatusProtocoloController(IStatusProtocolo statusProtocoloHandler) => StatusProtocoloHandler = statusProtocoloHandler;


        [HttpPost("Add")]
        public async Task<IActionResult> Add(AddStatusProtocolo request)
        {
            try
            {
                var result = await StatusProtocoloHandler.AddStatusProtocolo(request);
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
        public async Task<IActionResult> GetById(GetStatusProtocoloById request)
        {
            try
            {
                var result = await StatusProtocoloHandler.GetStatusProtocoloById(request);
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
        public async Task<IActionResult> GetAll(GetTodosStatusProtocolo request)
        {
            try
            {
                var result = await StatusProtocoloHandler.GetTodosStatusProtocolo(request);
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
        public async Task<IActionResult> Update(UpdateStatusProtocolo request)
        {
            try
            {
                var result = await StatusProtocoloHandler.UpdateStatusProtocolo(request);
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
        public async Task<IActionResult> Delete(DeleteStatusProtocolo request)
        {
            try
            {
                var result = await StatusProtocoloHandler.DeleteStatusProtocolo(request);
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
