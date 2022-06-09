using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Blog.Persistence.Configuration;

internal class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
{
    public void Configure(EntityTypeBuilder<BlogPost> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(b => b.Title)
            .IsRequired()
            .HasColumnType("nvarchar")
            .HasMaxLength(300);

        builder.Property(b => b.Content)
            .IsRequired()
            .HasColumnType("nvarchar");

        builder.Property(b => b.Author)
            .IsRequired();
    }
}
