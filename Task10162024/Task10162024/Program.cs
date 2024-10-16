namespace Task10162024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Grade[] grds = [
                new Grade(90,4),
                new Grade(70,4),
                new Grade(77,4),
                new Grade(87,4),
                new Grade(93,4)
            ];
            Grade[] grds2 = [
                new Grade(51,4),
                new Grade(55,4)
            ];
            Student elmin = new Student();
            elmin.Grades = grds;
            elmin.Name = "Elmin";

            Console.WriteLine(elmin.GetAvgGrade());
        }
    }
}
