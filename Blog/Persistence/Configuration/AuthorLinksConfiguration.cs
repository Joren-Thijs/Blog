using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Blog.Persistence.Configuration;

internal class AuthorLinksConfiguration
{
    public static Action<OwnedNavigationBuilder<T, AuthorLinks>> Configure<T>()
        where T : class => builder =>
    {
        builder.Property(a => a.Website)
            .HasConversion(uri => uri != null ? uri.AbsoluteUri.ToLower() : string.Empty, s => new Uri(s))
            .HasMaxLength(2048)
            .HasColumnType("varchar");

        builder.Property(a => a.Twitter)
            .HasConversion(uri => uri != null ? uri.AbsoluteUri.ToLower() : string.Empty, s => new Uri(s))
            .HasMaxLength(2048)
            .HasColumnType("varchar");

        builder.Property(a => a.LinkedIn)
            .HasConversion(uri => uri != null ? uri.AbsoluteUri.ToLower() : string.Empty, s => new Uri(s))
            .HasMaxLength(2048)
            .HasColumnType("varchar");
    };
}
