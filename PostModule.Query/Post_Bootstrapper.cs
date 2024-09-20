using Microsoft.Extensions.DependencyInjection;
using PostModule.Application.Contract.StateQuery;
using PostModule.Applicatoin.Services;
using PostModule.Infrastructure.EF;
using PostModule.Query.Services;


namespace PostModule.Query
{
    public class Post_Bootstrapper
    {
        public static void Config(IServiceCollection services, string connectionString)
        {
            PostInfrastructure_Bootstrapper.Config(services, connectionString);
            PostApplication_Bootstrapper.Config(services);

            services.AddTransient<IStateQuery, StateQuery>(); 
        }
    }
}
