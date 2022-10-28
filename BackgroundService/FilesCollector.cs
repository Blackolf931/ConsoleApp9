using Quartz;
using Shared;

namespace BackgroundService
{
    public class FilesCollector : IJob
    {
        public async Task Execute(IJobExecutionContext context)
        {
            Console.WriteLine(1);
            await GetFiles();
        }

        public async Task<IEnumerable<string>> GetFiles()
        {
            var directory = new DirectoryInfo($"{Directory.GetCurrentDirectory()}\\{Consts.directoryPath}");
            Console.WriteLine(directory.FullName);
            try
            {
                var files = directory.GetFiles("*.json");
                return ReadFiles(files);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException(ex.Message);
            }
        }
        public IEnumerable<string> ReadFiles(IEnumerable<FileInfo> files)
        {
            var filesInfo = new List<string>();
            foreach (var el in files)
            {
                filesInfo.Add(File.ReadAllText(el.FullName));
                el.Delete();
            }
            return filesInfo;
        }
    }
}
