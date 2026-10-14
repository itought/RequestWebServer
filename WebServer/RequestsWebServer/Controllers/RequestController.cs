using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using WebServer.Application;

namespace RequestsWebServer.Controllers
{
    [AllowAnonymous]
    [Route("api/requests")]
    public class RequestController : ControllerBase
    {
        IRequestService service;

        public RequestController(IRequestService _service) => service = _service;

        [HttpPost("create-request")]
        public async Task<ActionResult<string>> CreateRequest([FromBody] CreateRequest request)
        {
            try
            {
                var requestData = await service.CreateRequest(request);

                if (requestData is not null)
                    return (JsonSerializer.Serialize(requestData, new JsonSerializerOptions { WriteIndented = true }));

                return "Request wasn't created";

            }
            catch(Exception? ex)
            {
                //Потом добавлю сюда логгер
                return Problem((ex).ToString());
            }
        }
    }
}
