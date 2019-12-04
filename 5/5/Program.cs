using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(input == 1 ? "Понедельник" : input == 2 ? "Вторник" : input == 3 ? "Среда" :
                input == 4 ? "Четверг" : input == 5 ? "Пятница" : input == 6 ? "Суббота" : input == 7 ? "Воскресенье" : "Такого дня недели не существует");
           

        }
    }
}
