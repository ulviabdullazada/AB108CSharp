using Polimorphism.Interfaces;
using System.Reflection;

namespace Polimorphism
{
    internal class Program : IFliable, ISwimable
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
            Dragon musa = new Dragon();
            Cat mestan = new Cat()
            {
                Name = "Mestan",
                Color = "Orange"
            };
            Parrot jack = new Parrot();
            Animal[] animals = [jack, musa, mestan];
            Parrot kea = new Kea();
            //foreach (var anm in animals)
            //{
            //    anm.Grow();
            //}
            //jack.Eat();
            //kea.Eat();
            //Console.WriteLine(mestan);
            //ISwimable[] swimables = [mestan, new Penguin()];
            //foreach (var item in swimables)
            //{
            //    item.Swim();
            //}
            ISwimable swim = mestan;
            swim.Test();
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        {
            throw new NotImplementedException();
        }
    }
}
