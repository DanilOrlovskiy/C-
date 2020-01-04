using System;

namespace ConsoleApp4
{
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
           Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
           Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
    class Program
    {
         
        static void Main(string[] args)
        {
            double ProKey = 123;
            double ExpKey = 1234;
            double key = 0;
            int menu = 2;
            do
            {
                Console.WriteLine("Вы хотите ввести ключ? 1-Да  2-Нет");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("Введите ключ:\n");
                    key = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    if (key == ProKey)
                    {
                        DocumentWorker DocWork = new DocumentWorker();
                        DocWork.OpenDocument();
                        DocWork = new ProDocumentWorker();
                        DocWork.EditDocument();
                        DocWork.SaveDocument();
                    }
                    else if (key == ExpKey)
                    {
                        DocumentWorker DocWork = new DocumentWorker();
                        DocWork.OpenDocument();
                        DocWork = new ProDocumentWorker();
                        DocWork.EditDocument();
                        DocWork = new ExpertDocumentWorker();
                        DocWork.SaveDocument();
                    }
                }
                else
                {
                    DocumentWorker DocWork = new DocumentWorker();
                    DocWork.OpenDocument();
                    DocWork.EditDocument();
                    DocWork.SaveDocument();
                }
                Console.WriteLine("\nЗакрыть программу? 1-Да  2-Попробовать еще раз");
                menu = Convert.ToInt32(Console.ReadLine());
            } while (menu == 2);
        }
    }
}
