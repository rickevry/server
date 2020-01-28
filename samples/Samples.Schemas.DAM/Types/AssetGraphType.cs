using GraphQL.Types;
using System;

namespace Samples.Schemas.DAM
{
    public class AssetGraphType : ObjectGraphType<Asset>
    {
        public AssetGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.AssetUrl);
            Field(o => o.Description);
            Field(o => o.Guid);
            Field(o => o.Title);
        }
    }
}
