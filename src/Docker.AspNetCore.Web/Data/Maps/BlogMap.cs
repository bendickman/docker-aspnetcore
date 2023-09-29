﻿using Docker.AspNetCore.Web.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Docker.AspNetCore.Web.Data.Maps;

public class BlogMap
{
    public BlogMap(
        EntityTypeBuilder<Blog> entityTypeBuilder)
    {
        entityTypeBuilder.HasKey(x => x.Id);
        entityTypeBuilder.ToTable("blog");

        entityTypeBuilder.Property(x => x.Id).HasColumnName("id");
        entityTypeBuilder.Property(x => x.Title).HasColumnName("title");
        entityTypeBuilder.Property(x => x.Description).HasColumnName("description");
    }
}
