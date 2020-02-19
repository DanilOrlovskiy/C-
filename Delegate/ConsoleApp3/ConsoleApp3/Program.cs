using System;

namespace ConsoleApp3
{
    class Program
    {
        delegate int Int();
        delegate int Calc(int[] array);

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива:  ");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arrayNum = new int[n];

            for (int i = 0; i < arrayNum.Length; i++)
            {
                Console.Write("\nВведите {0}-й Элемент массива: ",i);
                arrayNum[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine();

            Calc calc = delegate (int[] array) 
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return ((sum) / (array.Length));
            };

            Console.WriteLine("Результат: {0}",calc(arrayNum));
        }
    }
}
