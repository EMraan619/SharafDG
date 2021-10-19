using MediatR;
using SharafDG.Application.Features.SME.Commands.CreateSME;
using SharafDG.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.Features.SME.Commands
{
   public  class CreateSMECommand : IRequest<Response<CreateSMEDto>>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string TypeOfBusiness { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public long CompanyPhone { get; set; }
        public string CompanyWebsite { get; set; }
        public long PhoneNumber { get; set; }
        public long AlternateNumber { get; set; }
    }
}
