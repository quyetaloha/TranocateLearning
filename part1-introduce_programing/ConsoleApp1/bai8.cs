using System;
using System.Collections.Generic;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('a', 0);
            dictionary.Add('e', 0);
            dictionary.Add('i', 0);
            dictionary.Add('o', 0);
            dictionary.Add('u', 0);

            Console.WriteLine("Nhap mot chuoi bat ki:");
            string test = Console.ReadLine();
            foreach (char c in test)
            {
                if (dictionary.ContainsKey(c))
                    dictionary[c] = dictionary[c] + 1;
            }
            foreach (char c in dictionary.Keys)
            {
                Console.WriteLine("nguyen am: " + c + " xuat hien " + dictionary[c]);
            }
        }
    }
}
