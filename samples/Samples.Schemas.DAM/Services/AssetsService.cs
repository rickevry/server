using System;
using System.Threading.Tasks;

namespace Samples.Schemas.DAM.Services
{
    public class AssetsService : IAssetsService
    {
        public Task<Asset> FindByAsync(Guid id)
        {
            return Task.FromResult(
                new Asset
                {
                    Guid = id.ToString(),
                    AssetUrl = "http://asset.url",
                    Description = "Asset description",
                    Title = "Asset title",
                });
        }
    }
}
