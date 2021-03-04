

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Person p = new Person("quyet","24");
            //Employee e = new Employee(1999);
            //e.Name = "kaka";
            //p = (Person) e;
            //Console.WriteLine(p.Name);
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Student[] stu;
            for(int i = 0; i < number; i++) { 
            Student student = new Student();
            Console.Write("Enter name: ");
            student.Name= Console.ReadLine();
            Console.Write("Enter id: ");
            student.Id = Console.ReadLine();
            student.display();
            }


        }
    }

    class Student
    {
        private String name { get; set; }
        private String id;
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
        public string Id   // property
        {
            get { return id; }
            set { id = value; }
        }
        public void display()
        {
            Console.WriteLine(name + id);
        }
    }

    class Person
    {
        private String name { get; set; }
        private String age;
        public Person() { }
        public string Name   // property
        {
            get { return name; }
            set { name = value; }
        }
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

