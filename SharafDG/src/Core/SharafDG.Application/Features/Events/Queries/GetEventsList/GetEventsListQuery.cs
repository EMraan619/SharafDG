using MediatR;
using SharafDG.Application.Responses;
using System.Collections.Generic;

namespace SharafDG.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery : IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
