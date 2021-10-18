using SharafDG.Application.Models.Mail;
using System.Threading.Tasks;

namespace SharafDG.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
