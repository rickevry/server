using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Samples.Schemas.DAM.Services
{
    public class PublicationsService : IPublicationsService
    {
        public Task<Publication> FindByAsync(Guid id)
        {
            return Task.FromResult(new Publication
            {
                Guid = id.ToString(),
                Title = "Test publication",
                Description = "Publication description",
                Editions = new List<Edition>
                {
                    new Edition
                    {
                        EditionNumber=1,
                        AssetsLinks=new List<AssetLink>
                        {
                            new AssetLink
                            {
                                AssetGuid=Guid.NewGuid().ToString(),
                                LanguageCode="en",
                            },
                            new AssetLink
                            {
                                AssetGuid=Guid.NewGuid().ToString(),
                                LanguageCode="se",
                            },
                        },
                    },
                    new Edition
                    {
                        EditionNumber=2,
                        AssetsLinks=new List<AssetLink>
                        {
                            new AssetLink
                            {
                                AssetGuid=Guid.NewGuid().ToString(),
                                LanguageCode="uk",
                            },
                            new AssetLink
                            {
                                AssetGuid=Guid.NewGuid().ToString(),
                                LanguageCode="se",
                            },
                        },
                    },
                },
            });
        }
    }
}
