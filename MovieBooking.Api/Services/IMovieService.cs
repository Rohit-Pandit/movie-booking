using MovieBooking.Api.Models;
namespace MovieBooking.Api.Services
{
    public interface IMovieService
    {
        Task<List<Movie>> GetMoviesAsync(string? language);
        Task<List<Movie>> GetMoviesByLocationAsync(int locationId);
    }
}