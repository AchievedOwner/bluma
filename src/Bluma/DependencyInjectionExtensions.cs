using Bluma;
using ComponentBuilder.Resolvers;

namespace Microsoft.Extensions.DependencyInjection;
public static class DependencyInjectionExtensions
{
    /// <summary>
    /// Change you name of extensions.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddBluma(this IServiceCollection services,Action<BlumaOptions>? configure=default)
    {
        var options = new BlumaOptions
        {
            Mode = ThemeMode.None
        };
        configure?.Invoke(options);
        if ( configure is not null )
        {
            services.PostConfigure(configure);
        }

        return services.AddComponentBuilder(options => options.AddDefaultConfigurations().AddFluentClassResolver());
    }
}
