using BLL.Models;

namespace BLL.Interfaces
{
    public interface IEmailNotificationServer : IGenericService<EmailNotification>
    {
         Task SendNotifications(EmailNotification entity, CancellationToken ct);
    }
}
