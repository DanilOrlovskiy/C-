using System;

namespace Class3
{
    class Program
    {
        class Book
        {
            public void book(string author, string title, string content)
            {
                Title Title = new Title();
                Title.Show(title);
                Author Author = new Author();
                Author.Show(author);
                Content Content = new Content();
                Content.Show(content);
            }

        }

    class Title
    {
           public void Show(string title)
           {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nНазвание книги: " + title);
                Console.ResetColor();
            }
    }
    class Author
    {
        public void Show(string author)
        {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nАвтор: " + author);
                Console.ResetColor();
            }
    }
    class Content
    {
        public void Show(string content)
        {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\nОписание: \n" + content);
                Console.ResetColor();
            }
    }
        static void Main(string[] args)
        {
            string t;
            string a;
            string c;
            Console.WriteLine("Введите название книги:");
            t = Console.ReadLine();
            Console.WriteLine("Введите автора книги:");
            a = Console.ReadLine();
            Console.WriteLine("Введите описание книги:");
            c = Console.ReadLine();
            Book book1 = new Book();
            book1.book(t, a, c);
        }
    }
}
