using Moq;
using SharafDG.Application.Contracts.Infrastructure;
using SharafDG.Application.Models.Mail;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharafDG.Application.UnitTests.Mocks
{
    public class EmailServiceMocks
    {
        public static Mock<IEmailService> GetEmailService()
        {
            var mockEmailService = new Mock<IEmailService>();
            mockEmailService.Setup(x => x.SendEmail(It.IsAny<Email>())).ReturnsAsync(true);
            return mockEmailService;
        }
    }
}
