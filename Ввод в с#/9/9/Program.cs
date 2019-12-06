using System;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму");
            int sum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Если Ваша валюта Гривна - введите 1, если доллар - 2, если евро - 3");
            int сurr = Convert.ToInt32(Console.ReadLine());
            if(сurr == 1)
            {
                Console.WriteLine("Ваша валюта Гривна");
                Console.WriteLine(sum + " гривен = " + (sum /23.9) + " долларов");
                Console.WriteLine(sum + " гривен = " + (sum / 26.5) + " евро");
            }
            else if (сurr == 2)
            {
                Console.WriteLine("Ваша валюта Доллар");
                Console.WriteLine(sum + " долларов = " + (sum * 23.9) + " гривен");
                Console.WriteLine(sum + " долларов = " + (sum * 0.9) + " евро");
            }
            else if (сurr == 3)
            {
                Console.WriteLine("Ваша валюта Евро");
                Console.WriteLine(sum + " евро = " + (sum * 26.5) + " гривен");
                Console.WriteLine(sum + " евро = " + (sum / 0.9) + " долларов");
            }
            else
            {
                Console.WriteLine("Такой валюты в приложении нет");
            }
        }
    }
}
