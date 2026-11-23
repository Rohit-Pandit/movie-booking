using Microsoft.EntityFrameworkCore;
using MovieBooking.Api.Data;
using MovieBooking.Api.Models;

namespace MovieBooking.Api.Services;

public class MovieService : IMovieService
{
    private readonly ApplicationDbContext _context;

    public MovieService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Movie>> GetMoviesAsync(string? language)
    {
        var moviesQuery = _context.Movies.AsQueryable();
        if(!string.IsNullOrEmpty(language))
        {
            moviesQuery = moviesQuery.Where(m => m.Language == language);
        }
        return await moviesQuery.ToListAsync();
    }
}
