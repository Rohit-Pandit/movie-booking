using Microsoft.AspNetCore.Mvc;
using MovieBooking.Api.DTOs;
using MovieBooking.Api.Services;

namespace MovieBooking.Api.Controllers;
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        var result = await _authService.RegisterAsync(request);
        if (!result)
        {
            return Conflict(new {message = "Email is already registered."});
        }
        return StatusCode(201, new {message = "User registered successfully."});
    }
}