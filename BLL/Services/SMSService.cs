using BLL.Interfaces;
using BLL.Models;

namespace BLL.Services
{
    public class SMSService : IGenericService<SMSNotifivcation>
    {
        public Task SendNotifications(SMSNotifivcation entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
