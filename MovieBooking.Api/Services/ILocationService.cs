using MovieBooking.Api.Models;

namespace MovieBooking.Api.Services;

public interface ILocationService
{
    Task<List<Location>> GetLocationsAsync();
}