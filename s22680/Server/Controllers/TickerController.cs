using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s22680.Server.Services;
using System.Threading.Tasks;

namespace s22680.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TickerController : ControllerBase
    {
        private readonly ITickerService _service;

        public TickerController(ITickerService service)
        {
            _service = service;
        }

        public async Task<IActionResult> GetTickers(string request)
        {
            return Ok(await _service.GetTickers(request));
        }
    }
}
