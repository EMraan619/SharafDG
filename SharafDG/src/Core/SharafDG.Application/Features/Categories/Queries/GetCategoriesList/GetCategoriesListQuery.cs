using MediatR;
using SharafDG.Application.Responses;
using System.Collections.Generic;

namespace SharafDG.Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoriesListQuery : IRequest<Response<IEnumerable<CategoryListVm>>>
    {
    }
}
