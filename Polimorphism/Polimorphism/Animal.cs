using Polimorphism.Interfaces;
using System.Threading.Channels;

namespace Polimorphism
{
    public abstract class Animal
    {
        //public void Eat()
        //{
        //    Console.WriteLine("Eat as animal");
        //}
        public virtual void Grow()
        {
            Console.WriteLine("Grow as animal");
        }
        public abstract void Eat();
    }
    abstract class Bird : Animal
    {
        public float WingLength { get; set; }
        //public void Fly()
        //{
        //    Console.WriteLine("Fly as bird");
        //}
        public override void Eat()
        {
            Console.WriteLine("Eat as bird. Wheat");
        }
    }
    class Penguin : Bird, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Swim as penguin");
        }
    }
    class Dragon : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Menyudan secib yeyir");
        }
        public void Fire()
        {
            Console.WriteLine("WWWwwWW");
        }
    }
    class Parrot : Bird
    {
        public void Say()
        {
            Console.WriteLine("Saalam");
        }
    }
    class Kea : Parrot
    {
        //public override void Eat()
        //{
        //    Console.WriteLine("Kea yemek yemir");
        //}
    }
    abstract class Domestic : Animal
    {
        public void Feed()
        {
            Console.WriteLine("nyam nyam");
        }
    }

    class Cat : Domestic, ISwimable
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public override void Grow()
        {
            Console.WriteLine("Pisik boyumur. Boyudur...!!!");
        }
        public override void Eat()
        {
            Console.WriteLine("Eating lasanya");
        }
        public override string ToString()
        {
            return GetType().ToString() + $" {{ Name = {Name}, Color = {Color} }}";
        }

        public void Swim()
        {
            Console.WriteLine("Swim as cat");
        }
    }
}
