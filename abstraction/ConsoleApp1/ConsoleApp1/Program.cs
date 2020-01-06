using System;

namespace ConsoleApp1
{
    abstract class AbstractHandler
    {
       public abstract void Open();
       public abstract void Create();
       public abstract void Change();
       public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
       public override void Open()
        {
            Console.WriteLine("Открыть XML");
        }
        public override void Create()
        {
            Console.WriteLine("Создать XML");
        }
        public override void Change()
        {
            Console.WriteLine("Изменить XML");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранить XML");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыть TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Создать TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Изменить TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранить TXT");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Открыть DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Создать DOC");
        }
        public override void Change()
        {
            Console.WriteLine("Изменить DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранить DOC");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string formatDoc;
            Console.WriteLine("Введите формат документа");
            formatDoc = Console.ReadLine();
            if(formatDoc == "xml")
            {
                XMLHandler xml = new XMLHandler();
                xml.Open();
                xml.Create();
                xml.Change();
                xml.Save();
            }
           else if (formatDoc == "txt")
            {
                TXTHandler txt = new TXTHandler();
                txt.Open();
                txt.Create();
                txt.Change();
                txt.Save();
            }
            else if (formatDoc == "doc")
            {
                DOCHandler doc = new DOCHandler();
                doc.Open();
                doc.Create();
                doc.Change();
                doc.Save();
            }
        }
    }
}
