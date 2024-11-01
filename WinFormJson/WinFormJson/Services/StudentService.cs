using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormJson.Models;

namespace WinFormJson.Services
{
    static class StudentService
    {
        const string path = @"C:\Users\ca r221.14\Desktop\AB108CSharp\WinFormJson\WinFormJson\Files\students.json";
        public static List<Student> GetAll()
        {
            using StreamReader sr = new StreamReader(path);
            var result = sr.ReadToEnd();
            return JsonConvert.DeserializeObject<List<Student>>(result);
        }
        public static void Add(Student student)
        {
            if (student.Name.Length > 2)
            {
                var list = GetAll();
                list.Add(student);
                var newList = JsonConvert.SerializeObject(list);
                using StreamWriter sw = new StreamWriter(path, false);
                sw.Write(newList);
            }
            else
            {
                MessageBox.Show("Uzunluq 3dən böyük olmalıdır");
            }
        }
    }
}
