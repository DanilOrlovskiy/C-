using System;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = "root";
            do
            {
                Console.WriteLine("Введите пароль.\n");
                string inputPass = Convert.ToString(Console.ReadLine());
                if (pass == inputPass)
                {
                    Console.WriteLine("Пароль верный!");
                    break;
                }
                else
                {
                    Console.WriteLine("\nПароль не верный! Попробуйте еще.\n");
                }
            }
            while (true);
        }
    }
}
