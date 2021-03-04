using System;
using System.Collections.Generic;
using System.Text;

namespace oop5
{
    class B5
    {
        
            private static void Main(string[] args)
        {
            Lion lion = new Lion();
            Lion.age = 120;
            Console.WriteLine(Lion.age);
            lion.drink();
        }
    }
    abstract class Animal
    {
        abstract public void eat();
        abstract public void drink();
    }
    interface DongVatAnThit
    {
        public void sanMoi();
    }
    class Person : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("person drink");
        }

        public override void eat()
        {
            Console.WriteLine("person eat");
        }

        public void sanMoi()
        {
            Console.WriteLine("person sanMoi");
        }
    }
    class Snake : Animal, DongVatAnThit
    {
        public override void drink()
        {
            Console.WriteLine("Snake drink");
        }

        public override void eat()
        {
            Console.WriteLine("Snake eat");
        }
        public void sanMoi()
        {
            Console.WriteLine("Snake sanMoi");
        }
    }
    class Lion : Animal, DongVatAnThit
        
    {
        public static int age = 100;
        public override void drink()
        {
            Console.WriteLine("Lion drink");
        }

        public override void eat()
        {
            Console.WriteLine("Lion eat");
        }

        public void sanMoi()
        {
            Console.WriteLine("Lion sanMoi");
        }
        public void Vomoi()
        {
            Console.WriteLine("Lion vomoi");
        }
    }
    sealed class LacDa
    {
        public const int age= 100;
        public void run()
        {
            Console.WriteLine("LacDa run "+age);
        }
    }
}
