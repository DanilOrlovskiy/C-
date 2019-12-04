using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());

            if((input == 1) || (input == 2) || (input == 12)){
                Console.WriteLine("Зима");
            }
            else if ((input == 3) || (input == 4) || (input == 5)){
                Console.WriteLine("Весна");
            }
            else if ((input == 6) || (input == 7) || (input == 8)){
                Console.WriteLine("Лето");
            }
            else if ((input == 9) || (input == 10) || (input == 11)){
                Console.WriteLine("Осень");
            }
            else {
                Console.WriteLine("На этой планете такого месяца - нет");
            }

        }
    }
}
