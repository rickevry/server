namespace Samples.Schemas.DAM
{
    public class AssetLink
    {
        public string LanguageCode { get; set; }
        // Id of asset from sep obj
        public string AssetGuid { get; set; }

        public Asset Asset { get; }
    }
}
