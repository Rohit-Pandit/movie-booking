
using Microsoft.AspNetCore.Mvc;
using MovieBooking.Api.Services;

namespace MovieBooking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowsController : ControllerBase
{
    private readonly IShowService _showService;

    public ShowsController(IShowService showService)
    {
        _showService = showService;
    }

    [HttpGet]
    public async Task<IActionResult> GetShows(
        [FromQuery] int movieId,
        [FromQuery] int locationId)
    {
        if (movieId <= 0 || locationId <= 0)
        {
            return BadRequest("Invalid movie or location ID.");
        }

        var shows = await _showService.GetShowsAsync(movieId, locationId);

        return Ok(shows);
    }
}
