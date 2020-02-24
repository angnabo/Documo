using System.IO;

namespace Documo.Services
{
    public class FileService
    {
        public static string ReadAllLines(string path)
        {
            return File.ReadAllText(path);
        }
    }
}