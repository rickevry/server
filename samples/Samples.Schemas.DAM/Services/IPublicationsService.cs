using System;
using System.Threading.Tasks;

namespace Samples.Schemas.DAM.Services
{
    public interface IPublicationsService
    {
        public Task<Publication> FindByAsync(Guid id);
    }
}
