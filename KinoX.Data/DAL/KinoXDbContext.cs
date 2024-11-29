using KinoX.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace KinoX.Data.DAL;

public class KinoXDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Hall> Halls { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Session> Sessions { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=KinoXDb;Trusted_Connection=true;TrustServerCertificate=true;");
    }
}
