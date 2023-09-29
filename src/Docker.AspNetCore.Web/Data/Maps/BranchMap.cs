using Docker.AspNetCore.Web.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Docker.AspNetCore.Web.Data.Maps;

public class BranchMap
{
    public BranchMap(
        EntityTypeBuilder<Branch> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(x => x.Id);
        entityTypeBuilder.ToTable("branch");

        entityTypeBuilder.Property(x => x.Id).HasColumnName("id");
        entityTypeBuilder.Property(x => x.Name).HasColumnName("name");
        entityTypeBuilder.Property(x => x.Description).HasColumnName("description");
    }
}
