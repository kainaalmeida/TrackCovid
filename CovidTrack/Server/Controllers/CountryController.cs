using CovidTrack.Shared.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CovidTrack.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountryController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        public async Task<IActionResult> Get()
        {
            var all = await _countryService.GetAll();
            return Ok(all);
        }
    }
}
