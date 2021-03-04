using System;
using System.Collections.Generic;
using System.Text;

namespace oop3
{
    class B3
    {
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

        public void eat()
        {
            Console.WriteLine("person eating");
        }
        public void eat(int speed)
        {
            Console.WriteLine("person speed running");
        }
        public void eat(String str)
        {
            Console.WriteLine("person str running");
        }


    }

    class Employee:Person
    {
        int Salary { get; set; }
        public Employee()
        {

        }
        public Employee(int salary)
        {
            this.Salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee display");
        }
    }
    class Doctor : Person
    {
        String Position { set; get; }
        public Doctor()
        {

        }
        public Doctor(String position)
        {
            this.Position = position;
        }
        public void display()
        {
            Console.WriteLine("Doctor display");
        }
    }

}
