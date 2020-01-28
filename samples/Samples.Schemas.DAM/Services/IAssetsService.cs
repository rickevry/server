using System;
using System.Threading.Tasks;

namespace Samples.Schemas.DAM.Services
{
    public interface IAssetsService
    {
        public Task<Asset> FindByAsync(Guid id);
    }
}
