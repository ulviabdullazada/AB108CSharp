using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace FileDirectory
{
    class FileHelper
    {
        public string Path { get; }
        public FileHelper(string path)
        {
            Path = path;
        }
        public async Task AppendAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path, true);
            await sw.WriteLineAsync(text);
        }
        public async Task ReplaceAsync(string text)
        {
            using StreamWriter sw = new StreamWriter(Path);
            await sw.WriteLineAsync(text);
        }
        public async Task<string> ReadAsync()
        {
            using StreamReader sr = new StreamReader(Path);
            return await sr.ReadToEndAsync();
        }
    }
}
