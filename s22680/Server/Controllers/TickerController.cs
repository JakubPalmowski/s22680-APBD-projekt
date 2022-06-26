using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using s22680.Server.Services;
using System.Threading.Tasks;

namespace s22680.Server.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class TickerController : ControllerBase
    {
        private readonly ITickerService _service;

        public TickerController(ITickerService service)
        {
            _service = service;
        }
        [HttpGet("{request}")]
        public async Task<IActionResult> GetTickers(string request)
        {
            return Ok(await _service.GetTickers(request));
        }

        [HttpGet("details/{request}")]
        public async Task<IActionResult> GetTickerDetails(string request)
        {
            return Ok(await _service.GetTickerDetails(request));
        }

        [HttpGet("stocks/{request}/{from}")]
        public async Task<IActionResult> GetStocks(string request, string from)
        {
            return Ok(await _service.GetStocks(request,from));
        }
    }
}
