using System;
using System.Collections.Generic;
using System.Text;

namespace oop4
{
    class B4
    {
        private static void Main(string[] args)
        {
            Person p = new Person("quyet", "24");
            p.Nhap();
            p.Hienthi();
            Student e = new Student();
            e.Di(200);
        }
    }
    class Person
    {
        public String Name { get; set; }
        public String Address { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }
        public Person(String name, String adress)
        {
            this.Name = name;
            this.Address = adress;
        }

        public void Nhap()
        {
            this.Name = "quyet";
            this.Address = "Ha Nam";
            this.Age = 18;
        }
        public void Hienthi()
        {
            Console.WriteLine(Name + Address + Age);
        }


    }

    class Student : Person
    {
        public void Di()
        {
            Console.WriteLine("Student di");
        }
        public void Di(int speed)
        {
            Console.WriteLine("Student di "+speed);
        }
    }
}
