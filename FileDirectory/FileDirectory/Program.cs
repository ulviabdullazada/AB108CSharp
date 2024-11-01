using FileDirectory.Models;
using Newtonsoft.Json;

namespace FileDirectory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            #region FileStream
            //string path = Path.Combine("C:", "Users", "ca r221.14", "Desktop", "AB101.txt");
            //Directory.CreateDirectory(path);
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            //using (StreamWriter sw = new StreamWriter(path, false))
            //{
            //    sw.WriteLine("");
            //}
            //using (StreamWriter sw = new StreamWriter(path, true))
            //{
            //    sw.WriteLine("Salam dostlar");
            //}
            //using (StreamReader sr = new StreamReader(path))
            //{
            //    Console.WriteLine(sr.ReadToEnd());
            //}
            //FileHelper ab101 = new FileHelper(path);

            //ab101.ReplaceAsync("Elmin yatir").Wait();
            //string text = ab101.ReadAsync().Result;
            //Console.WriteLine(text);
            #endregion
            #region Json
            //string result = JsonConvert.SerializeObject(std);
            //JsonConvert.DeserializeObject<Student>(result);
            //Console.WriteLine(result);
            FileHelper stds = new(@"C:\Users\ca r221.14\Desktop\AB108CSharp\FileDirectory\FileDirectory\Files\students.json");
            string studentsStr = stds.ReadAsync().Result;
            var list = JsonConvert.DeserializeObject<List<Student>>(studentsStr);
            Student std = new Student
            {
                Name = "Selcan",
                Surname = "Karimli"
            };
            list.Add(std);
            string result = JsonConvert.SerializeObject(list);
            stds.ReplaceAsync(result).Wait();
            #endregion
        }

    }
}
