using System;

namespace Class8
{
    class Invoice
    {
        public int account;
        public string customer;
        public  string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }
        public double Price()
        {
            account *= quantity;
            return account;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10000, "ООО 'Покупатель' ", "ООО 'Поставщик'", "Компьютер", 2);
            Console.WriteLine("Покупатель: {0}\nПродавец: {1}\nСумма заказа с НДС: {2}\nСумма заказа без НДС: {3}\n", invoice.customer, invoice.provider,invoice.account, invoice.account*0.2+invoice.account);
            Console.ReadKey();
        }
    }
}