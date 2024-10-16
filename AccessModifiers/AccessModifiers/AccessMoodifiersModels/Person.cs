namespace AccessModifiers.Models
{
    class Person
    {
        //1 - public - a,b,c
        //2 - protected - b,c
        //3 - private - c
        //Access modifier nedir?
        //a - instance 
        //b - inheritance
        //c - inner class
        public string Name;
        protected string Surname;
        private int Age;
        public Person()
        {
            Name = "asdhasdjh";
            Surname = "123123";
            Age = 20;
        }
        
    }
}
