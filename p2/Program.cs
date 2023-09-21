using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void F2()
        {
            SNN(5); 
        }
        static void SNN(int a)
        {
            int s = 0; 

            for (int i = 1; i <= a; i++)
            {
                Console.Write("Введите число: ", i);
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    s += n;
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                    i--; 
                }
            }
            Console.WriteLine("Сумма введенных чисел: " + s);
        }
        static void Main(string[] args)
        {
            F3();
        }


        static void F3()
        {
            bool num = false; 

            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Введите число: ", i);
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    if (n > 0)
                    {
                        num = true; 
                    }
                }
                else
                {
                    Console.WriteLine("Введите целое число");
                    i--; 
                }
            }

            Console.WriteLine("Среди введенных чисел есть положительное: " + num);
        }




        //2. еще задачку на if: написать проверки для склонения слова "рублей" в зависимости от введенного значения.допустим, вводишь 25, выводится "25 рублей", вводишь 2,
        //выводится "2 рубля" и т.д.подумать какие м.б.варианты, и реализовать.
        static void PR2()
        {
            int a;
            Console.WriteLine("Введите количество рублей");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);

            PR2(a);
        }
        static void PR2(int a)
        {
            if (a < 0)
            {
                Console.WriteLine("Денежная валюта не может быть отрицательной (пока что)");
            }
            else
            {
                if (a % 10 == 1 && a % 100 != 11)
                {
                    Console.WriteLine($"{a} рубль");
                }
                else if ((a % 10 >= 2 && a % 10 <= 4) && (a % 100 < 10 || a % 100 >= 20))
                {
                    Console.WriteLine($"{a} рубля");
                }
                else
                {
                    Console.WriteLine($"{a} рублей");
                }
            }
        }

        static void PR3()
        {
            int a;
            Console.WriteLine("Введите трехзначное число");
            string tmp = Console.ReadLine();
            a = int.Parse(tmp);

            PR3(a);
        }
        static void PR3(int a)
        {
            if (100 > a || a > 999)
            {
                Console.WriteLine("Число не является трехзначным");
            }
            else
            {
                int ff = a / 100;
                int gg = a % 10;
                if (ff == gg)
                {
                    Console.WriteLine("Число является палиндромом");
                }
                else
                {
                    Console.WriteLine("Число не является палиндромом");
                }
            }
        }







    }
}










