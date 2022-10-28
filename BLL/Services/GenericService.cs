using BLL.Interfaces;

namespace BLL.Services
{
    public class GenericService<TModel> : IGenericService<TModel>
    {
        public Task SendNotifications(TModel entity, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}
