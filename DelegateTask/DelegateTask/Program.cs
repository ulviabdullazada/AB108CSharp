//Exam class

// - Student
// - Point
// - Subject
// - StartDate
// - EndDate


//Exams siyahisi duzeldirsiniz
//Butun examleri daxil etdikden sonra console-da asagidaki siyahilari gosterirsiniz:
//- pointi 50 - den cox olan  examlarin siyahisini gosterirsiniz
//- son 1 hefte erzinde olan  examlarin siyahisini gosterirsiniz
//- 1-saatdan uzun ceken imtahanlarin siyahisi


//Siyahilari gosterende asagidaki datalari gosterirsiniz her bir siyahi ucun
// - StudentName  Subject  Point  Duration

using DelegateTask.Extensions;
using DelegateTask.Models;

List<Exam> exams = [
        new Exam(new Student("Ruslan", "Bayramov"),90, "Programming", new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,12,05,00)),
        new Exam(new Student("Naciba", "Rasulova"),95, "Programming", new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,11,55,23)),
        new Exam(new Student("Selcan", "Karimli"),100, "Programming", new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,11,05,00)),
        new Exam(new Student("Elmin", "Alizada"),32, "Programming", new DateTime(2024,10,30,10,00,00),new DateTime(2024,10,30,10,05,46))
    ];

//exams.FindAll(x => x.Point > 50).PrintExam();
//exams.FindAll(x => DateTime.Now.AddDays(-7) < x.StartDate).PrintExam();
exams.FindAll(GetExamsLongerThan1Hour).PrintExam();
static bool GetExamsLongerThan1Hour(Exam x)
{
    return (x.EndDate - x.StartDate).TotalHours >= 1;
}