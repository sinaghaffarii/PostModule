using Microsoft.Extensions.DependencyInjection;
using PostModule.Application.Contract.CityApplication;
using PostModule.Application.Contract.StateApplication;


namespace PostModule.Applicatoin.Services
{
    public class PostApplication_Bootstrapper
    {
        public static void Config(IServiceCollection services)
        {
            services.AddTransient<IStateApplicatoin, StateApplicatoin>();
            services.AddTransient<ICityApplication, CityApplication>();
        }
    }
}
