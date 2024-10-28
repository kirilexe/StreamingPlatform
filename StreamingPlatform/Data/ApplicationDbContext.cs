using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using StreamingPlatform.Models;


public class ApplicationDbContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<MusicVideo> MusicVideos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer("YourConnectionString");
    }
}
