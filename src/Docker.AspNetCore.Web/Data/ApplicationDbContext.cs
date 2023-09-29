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

    public DbSet<Branch> Branches { get; set; }

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new BranchMap(modelBuilder.Entity<Branch>());
    }
}
