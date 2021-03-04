using System;
using System.Collections.Generic;
using System.Text;

namespace oop2
{
    class B2
    {
        private static void Main(string[] args)
        {
            Person p = new Person("quyet", "24");
            Employee e = new Employee();
            e.BasicSalary = 200;
            ((Person) e).run();
        }
    }
    class Person
    {
        public String Name { get; set; }
        public String Age { get; set; }

        public Person()
        {

        }
        public Person(String name, String age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void Run(){
            Console.WriteLine("person running");
            }


    }

    class Employee : Person
    {
            public double BasicSalary { get; set; }
        public double CalculateSalary()
        {
            return BasicSalary;
        }
        public double CalculateSalary(int bonus, int punishment)
        {
            return BasicSalary + bonus - punishment;
        }
        public double CalculateSalary(int bonus, int punishment, int extra)
        {
            return BasicSalary + bonus - punishment+ extra;
        }

        public void Run()
        {
            Console.WriteLine("Employee running");
        }
    }
}
