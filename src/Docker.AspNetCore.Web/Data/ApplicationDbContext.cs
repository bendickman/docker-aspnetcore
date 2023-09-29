using Docker.AspNetCore.Web.Data.Maps;
using Docker.AspNetCore.Web.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Docker.AspNetCore.Web.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Blog> BlogPosts { get; set; }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new BlogMap(modelBuilder.Entity<Blog>());
    }
}
