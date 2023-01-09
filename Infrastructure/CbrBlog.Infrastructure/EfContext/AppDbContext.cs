using CbrBlog.Domain.DbModels;
using Microsoft.EntityFrameworkCore;

namespace CbrBlog.Infrastructure.EfContext
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
