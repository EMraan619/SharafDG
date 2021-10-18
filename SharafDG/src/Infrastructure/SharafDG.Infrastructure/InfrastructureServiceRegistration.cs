using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharafDG.Application.Contracts.Infrastructure;
using SharafDG.Application.Models.Mail;
using SharafDG.Infrastructure.Mail;

namespace SharafDG.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<ICsvExporter, CsvExporter>();
            services.AddTransient<IEmailService, EmailService>();
            return services;
        }
    }
}
