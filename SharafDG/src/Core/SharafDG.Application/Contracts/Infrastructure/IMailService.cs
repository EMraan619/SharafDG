using SharafDG.Application.Models.Mail;
using System.Threading.Tasks;

namespace SharafDG.Application.Contracts.Infrastructure
{
    public interface IMailService
    {
        Task SendEmailAsync(Email mailRequest);
    }
}
