using Microsoft.EntityFrameworkCore;
using PostModule.Domain.StateEntity;
using PostModule.Domain.CityEntity;
using PostModule.Infrastructure.EF.Mapping;

namespace PostModule.Infrastructure.EF
{
    internal class Post_Context : DbContext
    {
        public Post_Context(DbContextOptions<Post_Context> options) : base(options)
        {

        }
        public DbSet<State> states { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StateMapping());
            modelBuilder.ApplyConfiguration(new CityMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
