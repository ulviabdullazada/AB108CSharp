namespace Static.Models
{
    abstract class Person
    {
        public abstract void Salam();
        public virtual void As()
        {
            Console.WriteLine("Aleykum");
            string a = "asdas";
        }
    }
}
