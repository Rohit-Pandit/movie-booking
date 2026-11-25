using Microsoft.EntityFrameworkCore;
using MovieBooking.Api.Data;
using MovieBooking.Api.Models;

namespace MovieBooking.Api.Services;

public class LocationService : ILocationService
{
    private readonly ApplicationDbContext _context; 

    public LocationService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Location>> GetLocationsAsync()
    {
        
        var locations = await _context.Locations.Where(l => l.IsActive).ToListAsync();
        return locations;
    }
}