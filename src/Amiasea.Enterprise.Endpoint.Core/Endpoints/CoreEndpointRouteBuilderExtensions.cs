using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Amiasea.Enterprise.Endpoint.Core;

public static class CoreEndpointRouteBuilderExtensions
{
    public static IEndpointRouteBuilder MapCoreEndpoints(
        this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGraphQL();

        return endpoints;
    }
}