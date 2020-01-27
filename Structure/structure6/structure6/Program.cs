using System;

namespace structure6
{
    enum Post
    {
        junior = 120,
        middle = 130,
        senior = 140
    }
    class Accauntant
    {
       public bool AskForBonus(Post worker, int hours)
        {
            int w = (int)worker;
            if (hours > w)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            bool result = acc.AskForBonus(Post.junior, 140);
            bool result2 = acc.AskForBonus(Post.senior, 130);
            Console.WriteLine("Примия для перого сотрудника - {0}", result.ToString());
            Console.WriteLine("Примия для второго сотрудника - {0}", result2.ToString());
        }
    }
}
