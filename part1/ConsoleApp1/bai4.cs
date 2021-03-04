using System;
using System.IO;

namespace TrancocateLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamWriter streamWriter = File.AppendText("file.txt");
            //streamWriter.WriteLine("quyet");
            //streamWriter.Close();
            Console.WriteLine("Thue phai no");
        }




        public void calulateTax(float salary)
        {
            if (salary > 500)
            {
                Console.WriteLine("Thue phai nop: "+ (salary*0.1).ToString());
            }
            else {
                Console.WriteLine("Ban khong phai nop thue");
            }
        }

        public void classifyStudent(int point)
        {
            if (point > 100)
            {
                Console.WriteLine("khong hop le");
            }
            else if(point > 80 && point <= 100)
            {
                Console.WriteLine("Gioi");
            }
            else if ((point > 70 && point <= 79))
            {
                Console.WriteLine("Kha");
            }
            else if ((point > 60 && point <= 69)){
                Console.WriteLine("TB Kha");
            }
            else if ((point > 50 && point <= 59))
            {
                Console.WriteLine("TB");
            }
            else if ( point < 50){
                Console.WriteLine("yeu");
            }

        }

        public static void calulateElictrict(int kw)
        {
            int amount = 0;
            int level = 0;
            int[] price = { 450, 600, 750, 900, 1000, 1200 };
            int[] step = { 100, 100, 100, 200, 500 };
            if (kw / 1000 > 1)
            {
                level = 5;
            }
            else if (kw / 500 > 1)
            {
                level = 4;
            }
            else if (kw / 300 > 1)
            {
                level = 3;
            }
            else if (kw / 200 > 1)
            {
                level =2;

            }
            else if (kw / 100 > 1)
            {
                level = 1;
            }
            else
            {
                level = 0;
            }
            for(int i = 0; i <= level; i++)
            {
                amount += kw * price[i];
                kw = kw - (i * price[i]);
            }
            Console.WriteLine(amount);
        }

        public static void sum100()
        {
            int sum = 0;
            int i = 100;
            while (i--!=0)
            {
                sum += i;
            }

        }

        public static void chiahetcho3()
        {
            int sum = 0;
            int i = 20;
            while (i++<50 && i%3==0)
            {
                Console.WriteLine(i+" ");
            }

        }

        public static void songuyen(int[] a,int length)
        {
            int i= 1;
            int max = a[0];
            do
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            } while (++i < 5);
            Console.WriteLine("so lon nhat: " + max);

        }

        public static void chiahetcho7(int[] a, int length)
        {
            int i = 1;
            int max = a[0];
            do
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            } while (++i < 5);
            Console.WriteLine("so lon nhat: " + max);

        }

    }

    
}


