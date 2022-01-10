using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int change;
            int max = 0;
            int min = 2147483647;
            int maxNumber = 0;
            int number;
            int counter = 1;
            double sum = 0;
            double a = 99;
            string buf;
            Console.WriteLine("Вариант №7 1 задание\n");
            Console.WriteLine("Введите количество чисел:");
            buf = Console.ReadLine();
            change = int.Parse(buf);
            for (int i = 0; i < change; i++)
            {
                Console.WriteLine($"Введите {i + 1} число");
                buf = Console.ReadLine();
                number = int.Parse(buf);
                if (max < number)
                {
                    max = number;
                    maxNumber = i;
                }
            }
            max = 0;
            Console.WriteLine($"Максимальное число находится под номером: {maxNumber + 1}");
            Console.ReadKey();
            Console.WriteLine("2 задание\n");
            do
            {
                Console.WriteLine($"Введите {counter} число");
                counter++;
                buf = Console.ReadLine();
                number = int.Parse(buf);
                if (max < number)
                    max = number;
                if (min > number && number != 0)
                    min = number;

            } while (number != 0);
            Console.WriteLine($"Сумма максимального: {max} и минимального: {min} равна: {max + min}");
            Console.ReadKey();
            Console.WriteLine("3 задание\n");
            do
            {
                sum += Math.Sqrt(a);
                a -= 3;
            } while (a > 3);
            Console.WriteLine($"Сумма sqrt(3 sqrt 6 (sqrt .... 99))) равна: {sum}");
            Console.ReadKey();
        }

        
    }
}
