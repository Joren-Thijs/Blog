using Microsoft.EntityFrameworkCore;
using Models;

namespace Blog.Persistence;

public class BlogContext : DbContext
{
    public BlogContext()
    {

    }

    public BlogContext(DbContextOptions<BlogContext> options) : base(options)
    {

    }

    DbSet<BlogPost> BlogPosts { get; set; } = default!;
}
