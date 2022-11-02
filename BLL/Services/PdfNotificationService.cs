using BLL.Interfaces;
using BLL.Models;
using Shared;

namespace BLL.Services
{
    public class PdfNotificationService : GenericService<PdfNotification>, IPdfNotificationService
    {
        public override async Task SendNotification(PdfNotification model)
        {
            var notification = new GenerateNotificationService().GenerateNotifications(model);

            await File.WriteAllTextAsync($"{Directory.GetCurrentDirectory()}\\{Consts.pdfNotification}\\{model.Name}.pdf", notification.ToString());
        }
    }
}
