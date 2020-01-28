using GraphQL;
using GraphQL.Types;
using Samples.Schemas.DAM.Services;
using Samples.Schemas.DAM.Types;
using System;

namespace Samples.Schemas.DAM
{
    public class DamQuery : ObjectGraphType
    {
        private readonly IAssetsService _assetsService;
        private readonly IPublicationsService _publicationsService;

        public DamQuery(IAssetsService assetsService, IPublicationsService publicationsService)
        {
            _assetsService = assetsService ?? throw new ArgumentNullException(nameof(assetsService));
            _publicationsService = publicationsService ?? throw new ArgumentNullException(nameof(publicationsService));

            BuildQueryFields();


        }

        private void BuildQueryFields()
        {
            Field<PublicationGraphType>(
                "publication",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "id" }
                ),
                resolve: context => _publicationsService.FindByAsync(context.GetArgument<Guid>("id")));

            Field<ListGraphType<AssetGraphType>>(
                "assets",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "id" }
                ),
                resolve: context => _assetsService.FindByAsync(context.GetArgument<Guid>("id")));
        }
    }
}
