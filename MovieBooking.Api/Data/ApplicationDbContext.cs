using Microsoft.EntityFrameworkCore;
using MovieBooking.Api.Models;

namespace MovieBooking.Api.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movies { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Location> Locations { get; set; }

    public DbSet<MovieLocation> MovieLocations { get; set; }

    public DbSet<Show> Shows { get; set; }
    public DbSet<Seat> Seats { get; set; }
    public DbSet<ShowSeat> ShowSeats { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ShowSeat>()
            .HasIndex(ss => new { ss.ShowId, ss.SeatId })
            .IsUnique();
    }
}