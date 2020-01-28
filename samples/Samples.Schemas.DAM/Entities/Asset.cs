namespace Samples.Schemas.DAM
{
    // separate doc in mongo
    // AssetService.FindByGuid()
    public class Asset
    {
        public string Guid { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string AssetUrl { get; set; }
    }
}
