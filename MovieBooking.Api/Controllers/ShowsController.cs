
using Microsoft.AspNetCore.Mvc;
using MovieBooking.Api.Services;

namespace MovieBooking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ShowsController : ControllerBase
{
    private readonly IShowService _showService;

    private readonly IShowSeatService _showSeatService;

    public ShowsController(IShowService showService, IShowSeatService showSeatService)
    {
        _showService = showService;
        _showSeatService = showSeatService;
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

    [HttpGet("{showId:int}/seats")]
    public async Task<IActionResult> GetSeats( int showId)
    {
        if (showId <= 0)
        {
            return BadRequest("Invalid show ID.");
        }

        var seats = await _showSeatService.GetShowSeatsAsync(showId);

        return Ok(seats);
    }
}
