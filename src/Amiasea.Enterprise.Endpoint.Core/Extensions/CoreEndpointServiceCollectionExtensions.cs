using Microsoft.Extensions.DependencyInjection;
using Amiasea.Enterprise.Operation.Core;
using Microsoft.Extensions.Configuration;

namespace Amiasea.Enterprise.Endpoint.Core;

public static class CoreEndpointServiceCollectionExtensions
{
    public static IServiceCollection AddCoreEndpoints(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddCoreOperations(configuration);

        services
            .AddGraphQLServer()
            .AddCoreTypes();

        return services;
    }
}