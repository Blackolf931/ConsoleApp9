using BLL.Models;

namespace BLL.Interfaces
{
    public interface IPdfNotificationService : IGenericService<PDFNotification>
    {
        Task GenerateNotification(SMSNotifivcation smsNotification);
    }
}
