using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Casting.Models
{
    abstract class Animal
    {
        public abstract void Eat();
    }
    class Fish : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Shark eats little fishes");
        }
        public virtual void Swim()
        {
            Console.WriteLine("Swim like a fish");
        }
    }
    class Shark : Fish
    {
        public void SayMeyxana()
        {
            Console.WriteLine("Akulalar oyaqdilar yatmayib");
        }
        public override void Eat()
        {
            Console.WriteLine("Shark eats little fishes");
        }
    }
    abstract class Bird : Animal
    {
        public virtual void Fly()
        {
            Console.WriteLine("Fly like a bird");
        }
    }
    class Sparrow : Bird
    {
        public override void Eat()
        {
            Console.WriteLine("Sparrow eats wheat");
        }
        public void Cikcik()
        {
            Console.WriteLine("Salam dostlar");
        }
    }
    abstract class Domestic : Animal
    {
        public virtual void Pet()
        {
            Console.WriteLine("Pet domestic animal");
        }
    }
    class Cat : Domestic
    {
        public override void Eat()
        {
            Console.WriteLine("Cat etas lasania");
        }
        public void InLive()
        {
            Console.WriteLine("Miyildayin dosdar");
        }
    }
}
