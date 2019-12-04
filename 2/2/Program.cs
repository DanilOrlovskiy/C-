using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myaw = "Мяу";
            string gav = "Гав";
            string input = Console.ReadLine();
            if (input == myaw)
            {
                Console.WriteLine("Покорми кота");
            }
            else if (input == gav)
            {
                Console.WriteLine("Погуляй с собакой");
            }
            else
            {
                Console.WriteLine("Неправильно");
            }
        }
    }
}
