using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.Features.SME.Command.DeleteSMEUser
{
    public class DeleteSMEUserCommand : IRequest
    {
        public int SMEId { get; set; }
    }
}
