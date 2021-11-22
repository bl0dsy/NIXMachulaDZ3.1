using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIXMachulaDZ3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Написать программу для нахождения суммы цифр произвольного целого числа n, значение которого находится в диапазоне [-2000000000…+2000000000] ");
            int n = Convert.ToInt32(Console.ReadLine());
            int summa = 0;
            while (n != 0)
            {
                int x = n % 10;
                summa += x;
                n /= 10;
            }
            int result = Math.Abs(summa);
            Console.WriteLine($"Сумма цифр указанного числа = {result}");
        }
    }
}
