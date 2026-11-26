using MovieBooking.Api.Models;
using MovieBooking.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace MovieBooking.Api.Services;

public class ShowService : IShowService
{
    private readonly ApplicationDbContext _context;

    public ShowService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Show>>GetShowsAsync(int movieId,int locationId)
    {
        var show = await _context.Shows
             .Where(s=> s.MovieId == movieId && s.LocationId == locationId && s.IsActive)
                .OrderBy(s => s.ShowStartTime)
                .ToListAsync();
        return show;
    }
}