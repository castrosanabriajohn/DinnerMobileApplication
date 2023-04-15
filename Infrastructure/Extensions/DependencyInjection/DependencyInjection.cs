using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Extensions.DependencyInjection;

public static class DependencyInjection
{
    // Static extension method for dependency injection.
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        return services;
    }
}
