using Microsoft.AspNetCore.Mvc;
using MovieBooking.Api.Services;

namespace MovieBooking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationsController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationsController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations()
        {
            var locations = await _locationService.GetLocationsAsync();
            return Ok(locations);
        }

    }
}
    