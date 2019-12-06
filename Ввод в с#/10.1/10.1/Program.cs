using System;

namespace _10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            n /= 10;
            while(n>0)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine("Количество разрядов: " + count);
        }
    }
}
