using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AstralVacancy.WebApi.Infrastructure
{
    public static class AppBuilderExtensions
    {
        public static T ConfigAndGet<T>(this IConfigurationSection configSection, IServiceCollection serviceCollection) where T : class
        {
            serviceCollection.Configure<T>(configSection);
            return configSection.Get<T>();
        }

        public static T ConfigAndGet<T>(this IConfiguration configuration, IServiceCollection serviceCollection, string sectionKey) where T : class
        {
            var section = configuration.GetSection(sectionKey);
            return section.ConfigAndGet<T>(serviceCollection);
        }
    }
}