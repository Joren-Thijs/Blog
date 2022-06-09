using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Blog.Persistence.Configuration;

internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.FirstName)
            .IsRequired()
            .HasColumnType("nvarchar");

        builder.Property(a => a.LastName)
            .IsRequired()
            .HasColumnType("nvarchar");

        builder.Property(a => a.Email)
            .IsRequired()
            .HasColumnType("nvarchar");

        builder.Property(a => a.Image)
            .HasConversion(uri => uri != null ? uri.AbsoluteUri.ToLower() : string.Empty, s => new Uri(s))
            .HasMaxLength(2048)
            .HasColumnType("varchar");

        builder.OwnsOne(a => a.Links, AuthorLinksConfiguration.Configure<Author>())
            .Navigation(a => a.Links)
            .IsRequired();
    }
}
