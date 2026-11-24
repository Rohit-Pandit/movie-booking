using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using MovieBooking.Api.Data;
using MovieBooking.Api.DTOs;

namespace MovieBooking.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPut("preferences")]
    public async Task<IActionResult> UpdatePreferences(
        UpdatePreferenceRequest request)
    {
        var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        if (!int.TryParse(userId, out var id))
        {
            return Unauthorized();
        }

        var user = await _context.Users.FindAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        user.PreferredLanguage = request.PreferredLanguage;

        await _context.SaveChangesAsync();

        return Ok(new
        {
            message = "Preferences updated successfully.",
            preferredLanguage = user.PreferredLanguage
        });
    }
}