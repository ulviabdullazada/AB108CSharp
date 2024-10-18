namespace RecordTuple.Models;

//class PersonClass
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//}
//record PersonRecord
//{
//    public string Name { get; set; }
//    public string Surname { get; init; }
//}
//record PersonRecord(string Name = "Said", string Surname = "Gambarli");
record Student(string Name, string Surname, string University, string Group);
//record Student : PersonRecord
//{
//    //public string Name { get; init; }
//    //public string Surname { get; init; }
//    public string University { get; init; }
//    public string Group { get; init; }
//    Student(string Name, string Surname, string University, string Group)
//    {
//        this.Name = Name;
//        this.Surname = Surname;
//        this.University = University;
//        this.Group = Group;
//    }
//}