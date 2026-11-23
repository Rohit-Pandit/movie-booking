using MovieBooking.Api.DTOs;
using MovieBooking.Api.Models;

namespace MovieBooking.Api.Services;
public interface IAuthService
{
    Task<bool> RegisterAsync(RegisterRequest request);
    Task<User?> LoginAsync(LoginRequest request);
}