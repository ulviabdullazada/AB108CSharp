using DelegateTask.Models;

namespace DelegateTask.Extensions
{
    static class ListExtensions
    {
        public static void PrintExam(this List<Exam> list)
        {
            list.ForEach(item => Console.WriteLine($"{item.Student.Name} {item.Subject} {item.Point} {(item.EndDate - item.StartDate)}"));
        }
    }
}
