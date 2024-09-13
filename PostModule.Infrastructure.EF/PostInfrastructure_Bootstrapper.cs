using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PostModule.Domain.Services;
using PostModule.Infrastructure.EF.Repositories;

namespace PostModule.Infrastructure.EF
{
    public class PostInfrastructure_Bootstrapper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            services.AddTransient<IStateRepository, StateRepository>();
            services.AddTransient<ICityRepository, CityRepository>();

            services.AddDbContext<Post_Context>(x =>
            {
                x.UseSqlServer(connectionString);
            });
        }
    }
}
