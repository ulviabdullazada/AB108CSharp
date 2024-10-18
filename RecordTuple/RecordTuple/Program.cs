namespace RecordTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Record
            //PersonClass personClass1 = new PersonClass
            //{
            //    Name = "Musa",
            //    Surname = "Abdullayev"
            //};
            //PersonClass personClass2 = new PersonClass
            //{
            //    Name = "Musa",
            //    Surname = "Abdullayev"
            //};
            //PersonRecord personRecord1 = new PersonRecord
            //{
            //    Name = "Naciba",
            //    Surname = "Rasulova"
            //};
            //PersonRecord personRecord2 = new PersonRecord
            //{
            //    Name = "Naciba",
            //    Surname = "Rasulova"
            //};
            //Console.WriteLine(personRecord1 == personRecord2);
            //PersonRecord personRecord3 = new PersonRecord()
            //{
            //    Surname = "asdasd"
            //};
            //Student elvin = new Student("Elvin", "Shukurlu", "AzTU", "AB108");
            //Student fidan = elvin with { Name = "Fidan", Surname = "Sultanli" };
            //Console.WriteLine(elvin);
            //Console.WriteLine(fidan);
            #endregion
            #region Tuple
            //var result = SaveFile("profilseklim.jpeg");
            //Console.WriteLine($"{result.SavePath} {result.FileName}");
            //(string path, string file) result = SaveFileWithTuple("asdasd.jpg");
            //Console.WriteLine(result.path + " " + result.file);
            var result = IntParse("271asdas76123");
            int.Parse("asdasda123");
            if (result.Item1)
            {
                Console.WriteLine(result.Item2);
            }
            else
            {
                Console.WriteLine("Eded deyil, yeke kiwisen");
            }
            #endregion
        }
        static (bool, int) IntParse(string value)
        {
            bool isNumber = int.TryParse(value, out var result);
            return (isNumber, result);
        }
        static (string Path, string File) SaveFileWithTuple(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            string fileNewName = Path.GetRandomFileName();
            string savePath = "imgs/profile-imgs";
            return (savePath, fileNewName + fileExtension);
        }
        static NewImage SaveFile(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            string fileNewName = Path.GetRandomFileName();
            string savePath = "imgs/profile-imgs";
            return new NewImage
            {
                SavePath = savePath,
                FileName = fileNewName + fileExtension,
            };
        }
    }
    class NewImage
    {
        public string SavePath { get; set; }
        public string FileName { get; set; }
    }
}
