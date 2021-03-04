using System;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 70;

            do
            {
                if (i % 7 == 0)
                    Console.WriteLine(i);
                i++;
            } while (i <= j);
        }
    }
}
