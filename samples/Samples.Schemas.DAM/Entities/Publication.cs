using System.Collections.Generic;

namespace Samples.Schemas.DAM
{
    // separate doc in mongo
    // PublicationService.FindByGuid()
    public class Publication
    {
        public string Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Edition> Editions { get; set; }
    }
}
