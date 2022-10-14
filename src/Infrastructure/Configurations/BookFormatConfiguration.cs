//using System;
//using Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace Infrastructure.Configurations
//{
//    public class BookFormatConfiguration
//    {
//        public BookFormatConfiguration()
//        {
//        }
//    }
//}

//public class BookFormatConfiguration : IEntityTypeConfiguration<BookFormats>
//{
//    public void Configure(EntityTypeBuilder<Category> builder)
//    {
//        builder.ToTable("BookFormats");
//        //builder.Property(x => x.).HasMaxLength(100).IsRequired(true);
//        //builder.Property(x => x.Description).HasMaxLength(500).IsRequired(false);
//    }

//    public void Configure(EntityTypeBuilder<BookFormats> builder)
//    {
//        builder.ToTable("BookFormats");

//    }
//}
