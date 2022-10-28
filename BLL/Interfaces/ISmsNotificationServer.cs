using BLL.Models;

namespace BLL.Interfaces
{
    public interface ISmsNotificationServer : IGenericService<SMSNotifivcation>
    {
        Task GenerateNotification(SMSNotifivcation smsNotification);
    }
}
