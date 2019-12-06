using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какое растояние вы проехали (в км)?");
            int km = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество минут простоя?");
            int time = Convert.ToInt32(Console.ReadLine());
            if(km<=5){

                Console.WriteLine("Сумма оплаты:" + (20 + time));
            }
             else{
                Console.WriteLine("Сумма оплаты:" + (((km-5)*3) + (20 + time)));
            }
        }
    }
}
