using GraphQL.Types;
using System;
using System.Collections.Generic;

namespace Samples.Schemas.DAM.Types
{
    public class PublicationGraphType : ObjectGraphType<Publication>
    {
        public PublicationGraphType()
        {
            BuildGraphTypeFields();
        }

        private void BuildGraphTypeFields()
        {
            Field(o => o.Description);
            Field(o => o.Title);
            Field(o => o.Guid);
            Field(o => o.Editions, true, typeof(ListGraphType<EditionGraphType>)).Resolve(context => context.Source.Editions);
        }
    }
}
