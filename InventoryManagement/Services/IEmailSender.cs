using System.Threading.Tasks;

namespace InventoryManagement.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}