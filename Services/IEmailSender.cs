using System.Threading.Tasks;

namespace WebApplicationBasic.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
