using System;
using System.IO;

namespace DemoFileWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name:");
            string filename = Console.ReadLine();
            if (!File.Exists(filename))
            {
                Console.WriteLine(filename + " khong ton tai file !");
            } else
            {
                StreamReader reader = File.OpenText(filename);
                string input;

                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                reader.Close();
            }


            StreamWriter writer = File.AppendText(filename);

            Console.WriteLine("Nhap 1 dong du lieu de ghi vao file!");
            string content = Console.ReadLine();

            writer.WriteLine("\r\n" + content);
            writer.Close();



        }
    }
}
