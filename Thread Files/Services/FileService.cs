

using System.Text;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Services
{
    public class FileService : IFileService
    {
        public Task DeleteAsync(string path)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteFileAsync(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
        public async Task<string> ReadFromFileAsync(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    return await sr.ReadToEndAsync();             
                }
            }
        }

        public async Task WriteToExsitFileAsync(string path, string text)
        {

            using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    await sw.WriteLineAsync(text);
                }
            }
        }

        public async Task WriteToNewFileAsync(string path, string text)
        {

            try
            {
                if (File.Exists(path))
                {
                    using (FileStream fs = new FileStream(path, FileMode.CreateNew, FileAccess.Write))
                    {
                        byte[] datas = Encoding.UTF8.GetBytes(text);
                        await fs.WriteAsync(datas, 0, datas.Length);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
 