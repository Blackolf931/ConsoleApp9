using BLL.Interfaces;
using BLL.Models;

namespace BLL.Services
{
    public class Pdfservice : IPdfNotificationService
    {
        public Task GenerateNotification(SMSNotifivcation smsNotification)
        {
            throw new NotImplementedException();
        }

        public Task SendNotifications(PDFNotification entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
