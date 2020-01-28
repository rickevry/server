using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace Samples.Schemas.DAM.Types
{
    public class EditionGraphType : ObjectGraphType<Edition>
    {
        public EditionGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.EditionNumber);
            Field(o => o.AssetsLinks, true, typeof(ListGraphType<AssetLinkGraphType>))
                .Resolve(context => context.Source.AssetsLinks);
        }
    }
}
