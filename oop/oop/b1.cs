using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake();
            snake.run();
        }
    }
    
    abstract class Person
    {
        public String Name { get; set; }
        abstract public void go();
        abstract public void run();


    }
    class Snake : Person
    {
        public override void go()
        {
            Console.WriteLine("Snake going");
        }

        public override void run()
        {
            Console.WriteLine("Snake running");
        }
    }

    class Bird : Person
    {
        public override void go()
        {
            Console.WriteLine("Bird going");
        }

        public override void run()
        {
            Console.WriteLine("Bird running");
        }
    }

    class Dog : Person
    {
        public override void go()
        {
            Console.WriteLine("Dog going");
        }

        public override void run()
        {
            Console.WriteLine("Dog running");
        }
    }
}
