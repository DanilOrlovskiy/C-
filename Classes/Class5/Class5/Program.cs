using System;

namespace Class5
{
    class Program
    {

        class Users
        {
            public void user(string login, string firstName, string lastName, string age, string date)
            {
                Console.WriteLine("\n\n Логин: {0} \n Имя: {1}  Фамилия: {2}\n Возраст: {3}\n\n Дата регистрации: {4}", login, firstName, lastName, age, date );
            }

        }
        static void Main(string[] args)
        {
         string login;
         string firstName;
         string lastName;
         string age;

        Console.WriteLine("Введите логин");
            login = Console.ReadLine();
            Console.WriteLine("Введите Имя");
            firstName = Console.ReadLine();
            Console.WriteLine("Введите Фамилию");
            lastName = Console.ReadLine();
            Console.WriteLine("Введите Возраст");
            age = Console.ReadLine();
            Console.WriteLine("Введите Дату регистрации");
            string date = Console.ReadLine();
            Users user = new Users();
            user.user(login, firstName, lastName, age, date);
        }
    }
}
