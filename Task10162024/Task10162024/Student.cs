namespace Task10162024
{
    class Student
    {
        public string Name;
        public string Surname;
        public Grade[] Grades;
        public float GetAvgGrade()
        {
            int sum = 0;
            foreach (var grd in Grades)
            {
                sum += grd.Point;
            }
            return Convert.ToSingle(sum) / Grades.Length;
        }
        public int GetCreditCount()
        {
            int sum = 0;
            foreach (Grade grd in Grades)
            {
                sum += grd.CreditCount;
            }
            return sum;
        }
    }
}
