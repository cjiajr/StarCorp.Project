using Microsoft.Extensions.DependencyInjection;
using StarCorp.Project.Application;

namespace StarCorp.Project.IoC
{
    public static class IoCConfiguration
    {
        public static void Configure(IServiceCollection services)
        {
            ConfigureApplication(services);
        }

        private static void ConfigureApplication(IServiceCollection services)
        {
            services.AddScoped<IStarCorpProjectApplication, StarCorpProjectApplication>();
        }
    }
}
