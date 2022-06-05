using System;

namespace HW_M_3._10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите число.");
            int number = int.Parse(Console.ReadLine());
            int i = 2;
            //int limit = number / 2 + 1; Решение первым способом

            double limit = Math.Sqrt(Convert.ToDouble(number)); //Решение вторым способом
            while (i < limit)
            {
                if (number % i == 0)
                {
                    Console.Write("Число не является простым.");
                    Console.ReadKey();
                    return;
                }
                i++;
            }
            Console.Write("Число является простым.");
            Console.ReadKey();
        }
    }
}
