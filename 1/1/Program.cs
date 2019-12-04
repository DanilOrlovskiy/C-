using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nВведите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b){
                Console.WriteLine("Значение" + a + " - Больше");
            }
            else if (a == b){
                Console.WriteLine("a = b");
            }
            else{
                Console.WriteLine("Значение " + b + " - Больше");
            }
            
        }
    }
}
