namespace BLL.Interfaces
{
    public interface IGenericService<TEntity>
    {
        Task SendNotifications(TEntity entity, CancellationToken ct);
    }
}
