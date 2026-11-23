using Microsoft.AspNetCore.Mvc;
using MovieBooking.Api.Services;

namespace MovieBooking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies([FromQuery] string? language)
        {
            var movies = await _movieService.GetMoviesAsync(language);
            return Ok(movies);
        }

        
    }
}