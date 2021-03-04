using System;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new int[5];
            for (int i = 0; i < 5; i++)
            {
                test[i] = Int32.Parse(Console.ReadLine());
            }

            int max = test[0];
            int j = 1;
            do
            {
                if (max < test[j])
                    max = test[j];
                j++;
            } while (j < 5);

            Console.WriteLine(max);
        }
    }
}
