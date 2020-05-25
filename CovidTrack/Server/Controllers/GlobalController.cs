using CovidTrack.Shared.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CovidTrack.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GlobalController : ControllerBase
    {
        private readonly IGlobalService _globalService;

        public GlobalController(IGlobalService globalService)
        {
            _globalService = globalService;
        }

        public async Task<IActionResult> Get()
        {
            var all = await _globalService.All();
            return Ok(all);
        }
    }
}
