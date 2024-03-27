

namespace Thread_Files.Services.Interfaces
{
    public interface IFileService
    {
        Task WriteToExsitFileAsync(string path, string text);
         Task<string> ReadFromFileAsync(string path);
        Task WriteToNewFileAsync(string path, string text);
        Task DeleteAsync(string path);
    }
}
