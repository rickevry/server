using GraphQL.Types;
using Samples.Schemas.DAM.Services;
using System;
using System.Threading.Tasks;

namespace Samples.Schemas.DAM.Types
{
    public class AssetLinkGraphType : ObjectGraphType<AssetLink>
    {
        private readonly IAssetsService _assetsService;

        public AssetLinkGraphType(IAssetsService assetsService)
        {
            _assetsService = assetsService ?? throw new ArgumentNullException(nameof(assetsService));

            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.AssetGuid);
            Field(o => o.LanguageCode);
            Field(o => o.Asset, false, typeof(AssetGraphType))
                .ResolveAsync(FindAssetByIdAsync);
        }

        private Task<Asset> FindAssetByIdAsync(IResolveFieldContext<AssetLink> context)
        {
            if (!string.IsNullOrWhiteSpace(context.Source.AssetGuid) &&
                Guid.TryParse(context.Source.AssetGuid, out var assetId))
            {
                return _assetsService.FindByAsync(assetId);
            }

            return null;
        }
    }
}
