using System;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int minute = 0;
            int customerCode = 0;
            int total = 0;
            do
            {
                showMenu();
                x = Int32.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Nhap so phut:");
                        minute = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap ma khach hang:");
                        customerCode = Int32.Parse(Console.ReadLine());
                        break;
                    case 2:
                        total = calculateFee(minute, customerCode);
                        Console.WriteLine("Cuoc cua khach hang la: " + total);
                        break;
                    case 3:
                        Console.WriteLine("So thue cua khach hang la: " + total / 10);
                        break;
                    case 4:
                        return;
                }
            } while (true);
        }

        static void showMenu()
        {
            Console.WriteLine("1.Nhap thong tin khach hang");
            Console.WriteLine("2.Tinh va in cuoc khach hang");
            Console.WriteLine("3.In so thue cua khach hang");
            Console.WriteLine("4.Thoat");
        }

        static int calculateFee(int minute, int customerCode)
        {
            int total = 0;
            if (customerCode == 0)
            {
                if (minute <= 200)
                {
                    total = (minute - 50) * 200 > 0 ? (minute - 50) * 200 : 0;
                } else if (minute <=400 )
                {
                    total = (minute - 200) * 80 + 150 * 200;
                } else
                {
                    total = (minute - 400) * 40 + 200 * 80 + 150 * 200;
                }
            } else
            {
                if (minute <= 200)
                {
                    total = minute * 200;
                }
                else if (minute <= 400)
                {
                    total = (minute - 200) * 80 + 200 * 200;
                }
                else
                {
                    total = (minute - 400) * 40 + 200 * 80 + 200 * 200;
                }
            }
            return total + 27000;
        }
    }
}
