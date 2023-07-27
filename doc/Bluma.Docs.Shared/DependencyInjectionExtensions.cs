using HighlightBlazor;
using Microsoft.Extensions.DependencyInjection;

namespace Bluma.Docs.Shared;
public static class DependencyInjectionExtensions
{
    public static IServiceCollection AddShared(this IServiceCollection services)
    {
        return services.AddHighlight();
    }
}
