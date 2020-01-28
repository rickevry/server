using Microsoft.Extensions.DependencyInjection;
using Samples.Schemas.DAM;
using Samples.Schemas.DAM.Services;
using Samples.Schemas.DAM.Types;

namespace GraphQL.Samples.Server
{
    public static class DamServicesConfiguration
    {
        public static IServiceCollection AddDamServices(this IServiceCollection services)
        {
            services.AddTransient<IAssetsService, AssetsService>();
            services.AddTransient<IPublicationsService, PublicationsService>();

            services.AddTransient<AssetLinkGraphType>();

            services.AddTransient<DamQuery>();

            return services;
        }
    }
}
