using System.Collections.Generic;

namespace Samples.Schemas.DAM
{
    public class Edition
    {
        public int EditionNumber { get; set; }
        public List<AssetLink> AssetsLinks { get; set; }
    }
}
