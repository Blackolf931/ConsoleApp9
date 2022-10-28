namespace BLL.Interfaces
{
    public interface IFilesService
    {
        Task<IEnumerable<string>> GetFiles();
    }
}
