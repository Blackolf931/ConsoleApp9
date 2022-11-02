using BLL.Interfaces;
using BLL.Models;
using Shared;

namespace BLL.Services
{
    public class EmailNotificationservice : GenericService<EmailNotification>, IEmailNotificatioNService
    {
        public override async Task SendNotification(EmailNotification model)
        {
            var notification = new GenerateNotificationService().GenerateNotifications(model);

            await File.WriteAllTextAsync($"{Directory.GetCurrentDirectory()}\\{Consts.emailNotification}\\{model.Name}.json", notification.ToString());
        }
    }
}
