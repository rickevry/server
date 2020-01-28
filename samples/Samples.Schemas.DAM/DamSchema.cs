
using GraphQL.Types;
using GraphQL.Utilities;
using System;

namespace Samples.Schemas.DAM
{
    public class DamSchema : Schema
    {
        public DamSchema(IServiceProvider provider) : base(provider)
        {
            Query = provider.GetRequiredService<DamQuery>();
            
        }
    }
}
