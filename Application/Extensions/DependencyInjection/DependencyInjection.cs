using Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions.DependencyInjection;

public static class DependencyInjection
{
    // Static extension method for dependency injection.
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register the IAuthenticationService interface with the container
        // and map it to the AuthenticationService implementation.
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        // Return the updated service collection.
        return services;
    }
}
