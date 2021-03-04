using System;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so can kiem tra chan le:");
            int x = Int32.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("chan");
            }
            else Console.WriteLine("le");
        }
    }
}
