using System;
using System.Collections.Generic;
using System.Text;

namespace TrancocateLearning
{
    class b1
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("ahihi");
            Person p = new Person();
            Employee e = new Employee(1999);
            Console.WriteLine(e.calculateSalary());

        }
    }

    class Person
    {
        private String name;
        private String age;
        public Person() { }
        public Person(String name, String age)
        {
            this.name = name;
            this.age = age;
        }

    }
    class Employee : Person
    {
        int basicSalary;
        public Employee(int basicSalary)
        {
            this.basicSalary = basicSalary;
        }
        public int calculateSalary()
        {
            return basicSalary;
        }
    }
}

