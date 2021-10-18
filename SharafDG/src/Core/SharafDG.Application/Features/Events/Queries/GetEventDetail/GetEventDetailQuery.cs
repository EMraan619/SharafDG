using MediatR;
using SharafDG.Application.Responses;
using System;

namespace SharafDG.Application.Features.Events.Queries.GetEventDetail
{
    public class GetEventDetailQuery : IRequest<Response<EventDetailVm>>
    {
        public string Id { get; set; }
    }
}
