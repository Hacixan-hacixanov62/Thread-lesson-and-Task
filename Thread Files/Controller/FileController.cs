

using Thread_Files.Services;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Controller
{
    public class FileController
    {
        private readonly IFileService _fileService;
        public FileController()
        {
            _fileService = new FileService();   
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\C#\\Thread Files\\File4.txt");
            Console.WriteLine(result);

        }

        public async Task CreateFileWithContentAsync()
        {
            await _fileService.WriteToNewFileAsync("C:\\C#\\Thread Files\\File4.txt", "Necesiz millet ? ");
        }

        public async Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C:\\C#\\Thread Files\\Thread Files");
        }

        public async Task WriteToNewFileAsync()
        {
            await _fileService.WriteToNewFileAsync("C:\\Users\\Hacixanov\\Desktop\\New folder (3)\\file34/txt", "Behruz bey"); 
        }

    }

} 
