using System;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 1)
            {
                for(int i=2; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        Console.WriteLine("Число не простое");
                    }
                    
                }
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число не простое");
            }

        }
    }
}
