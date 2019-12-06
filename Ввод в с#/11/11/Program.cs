using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 146);
            while(true)
            {
                Console.WriteLine("Введите число");
                int value2 = Convert.ToInt32(Console.ReadLine());

                if (value == value2)
                {
                    Console.WriteLine("Вы угадали, " + value + " - загаданное число");
                    break;
                }
                else if (value < value2)
                {
                    Console.WriteLine("Вы не угадали, загаданное число Меньше");
                }
                else
                {
                    Console.WriteLine("Вы не угадали, загаданное число Больше");
                }
            }
            Console.WriteLine("Конец");
        }
    }
}
