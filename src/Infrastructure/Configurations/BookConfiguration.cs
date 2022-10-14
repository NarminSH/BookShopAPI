using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class BookConfiguration
    {
        public BookConfiguration()
        {
        }
    }
}

public class BookConfiguration : IEntityTypeConfiguration<Book>
{

    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Title).IsRequired(true);
        builder.Property(x => x.DiscountPriceId).IsRequired(false);
    }
}
