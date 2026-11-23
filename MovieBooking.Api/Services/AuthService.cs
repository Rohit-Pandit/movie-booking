using Microsoft.EntityFrameworkCore;
using MovieBooking.Api.Data;
using MovieBooking.Api.DTOs;
using MovieBooking.Api.Models;
using Microsoft.AspNetCore.Identity;

namespace MovieBooking.Api.Services;
public class AuthService : IAuthService
{
    private readonly ApplicationDbContext _context;
    private readonly IPasswordHasher<User> _passwordHasher;

    public AuthService(ApplicationDbContext context, IPasswordHasher<User> passwordHasher)
    {
        _context = context;
        _passwordHasher = passwordHasher;
    }

    public async Task<bool> RegisterAsync(RegisterRequest request)
    {

        var email = request.Email.Trim().ToLowerInvariant(); 
        
        if (await _context.Users.AnyAsync(u => u.Email == email))
        {
            return false; 
        }

        
        var user = new User
        {
            FullName = request.FullName.Trim(),
            Email = email,
            PasswordHash = string.Empty,
        };

        user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return true; 
    }


    public async Task<User?> LoginAsync(LoginRequest request)
    {
        var email = request.Email.Trim().ToLowerInvariant(); 
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        if (user == null)
        {
            return null; 
        }

        var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
        if (verificationResult == PasswordVerificationResult.Failed)
        {
            return null; 
        }
        if(verificationResult == PasswordVerificationResult.SuccessRehashNeeded)
        {
            user.PasswordHash = _passwordHasher.HashPassword(user, request.Password);
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        return user; 
    }
}