using MovieBooking.Api.Models;


namespace MovieBooking.Api.Services;
public interface IShowService
{
    Task<List<Show>>GetShowsAsync(int movieId,int locationId);
}