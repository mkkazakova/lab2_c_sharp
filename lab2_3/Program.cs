using System;
using Library;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Pro");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Pro");
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
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert");
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
        Console.Write("Введите ключ доступа (pro/exp): ");
        string key = Console.ReadLine();

        DocumentWorker document;

        // Пароль для pro 111, expert 222
        if (key == Keys.ProKey)
        {
            document = new ProDocumentWorker();
        }
        else if (key == Keys.ExpKey)
        {
            document = new ExpertDocumentWorker();
        }
        else
        {
            document = new DocumentWorker();
        }

        document.OpenDocument();
        document.EditDocument();
        document.SaveDocument();
    }
}