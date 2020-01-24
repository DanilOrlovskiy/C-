using System;

namespace structure1
{
    struct Notebook
    {
        public string Model;
        public string Manufacturer;
        public string Price;
        public void GetInfo()
        {
            Console.WriteLine($"Модель: {Model} \nПроизводитель: {Manufacturer} \nЦена: {Price}");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebooks;
            notebooks.Model = "A1398";
            notebooks.Manufacturer = "Apple";
            notebooks.Price = "800";
            notebooks.GetInfo();
        }
    }
}
