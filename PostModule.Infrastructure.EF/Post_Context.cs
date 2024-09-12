using Microsoft.EntityFrameworkCore;
using PostModule.Domain.StateEntity;
using PostModule.Domain.CityEntity;

namespace PostModule.Infrastructure.EF
{
    internal class Post_Context : DbContext
    {
        public Post_Context(DbContextOptions<Post_Context> options) : base(options)
        {

        }
        public DbSet<State> states { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
