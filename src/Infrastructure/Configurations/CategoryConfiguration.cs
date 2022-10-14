using System;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired(true);
        builder.HasMany(x => x.Children).WithOne(x => x.Parent)
            .HasForeignKey(x => x.ParentId).OnDelete(DeleteBehavior.Restrict)
            .IsRequired(false);
        
    }
}