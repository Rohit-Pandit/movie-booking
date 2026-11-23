using Microsoft.EntityFrameworkCore;

namespace MovieBooking.Api.Models;

[Index(nameof(Email), IsUnique = true)]
public class User
{
    public int Id { get; set; }
    public required string FullName { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }

    public string PreferredLanguage { get; set; } = "English"; 
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

}