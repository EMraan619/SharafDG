using MediatR;
using SharafDG.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.Features.SME.Queries
{
    public class GetSMEDetailQuery : IRequest<Response<SMEDetailVm>>
    {
        public int SMEId { get; set; }
    }
}
