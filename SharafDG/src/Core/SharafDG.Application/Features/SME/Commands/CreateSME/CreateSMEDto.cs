using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.Features.SME.Commands.CreateSME
{
   public class CreateSMEDto
    {
        public int SMEId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string TypeOfBusiness { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public long CompanyPhone { get; set; }
        public string CompanyWebsite { get; set; }
        public long PhoneNumber { get; set; }
        public long AlternateNumber { get; set; }
    }
}
