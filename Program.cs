using System;

namespace _28._08._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ключ 'pro' или 'exp'");
            ProDocumentWorker doc = new ExpertDocumentWorker();
            doc.key = Console.ReadLine();
            doc.OpenDocument();
            doc.EditDocument();
            doc.SaveDocument();
            Console.ReadLine();
        }
    }
    class DocumentWorker
    {
        public string key = null;
        public void OpenDocument()
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
            if (key == "pro" || key == "exp") Console.WriteLine("Документ отредактирован");
            else base.EditDocument();
        }
        public override void SaveDocument()
        {
            if (key == "pro") Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
            else base.SaveDocument();
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            if (key == "exp") Console.WriteLine("Документ сохранен в новом формате");
            else base.SaveDocument();
        }
    }
   
}
