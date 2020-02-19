using System;
using System.Text;

namespace _4
{
    class Program
    {
        public string Input { get; set; }

        public void Substring(int a, int b)
        {
            var builder = new StringBuilder();
            foreach (var symbol in Input)
            {
                if (symbol != Input[a])
                {
                    builder.Append(symbol);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(builder.ToString());

            return;
        }

        public void IndexOf(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 't')
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Replace(string input, string input2)
        {
            for (int i = 0; i <= input.Length; i++)
            {
                if(Input[i] == input[i])
                {
      
                }
                else
                {
                    break;
                }
                return;
            }
        }
    }
    class MyMain
    {
            static void Main(string[] args)
            {
            Program prog = new Program();
            prog.Input = "Hello World";

            int b = 3;
            int a = 2;
            string a3 = "e";
            string b3 = "y";

            prog.Substring(a, b);
            prog.Replace(a3, b3);
            }
    }
    
}
