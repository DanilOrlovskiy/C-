using System;

namespace _2
{
    static class Sorting
    {
        public static void GetSorting(int[] array, int n)
        {
            int temp;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            Console.WriteLine("\n Массив");
            for (int i = 0; i < n; i++) 
            {
                Console.Write(array[i] + " ");
            }
            return;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = Int32.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Введите массив");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" {0}-й элемент: ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Sorting.GetSorting(array, n);
        }
    }
}
