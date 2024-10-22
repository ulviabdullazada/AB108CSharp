namespace Static.Models
{
    class Teacher : Person
    {
        public sealed override void Salam()
        {
            Console.WriteLine("Salam");
        }
    }
}
