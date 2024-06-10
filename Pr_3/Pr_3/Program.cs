using System;

class Title
{
    private string _title;

    public string TitleName
    {
        get { return _title; }
        private set
        {
            if (_title == null)
            {
                _title = value;
            }
            else
            {
                throw new InvalidOperationException("Назва книги може бути задана лише один раз.");
            }
        }
    }

    public Title(string title)
    {
        TitleName = title;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Назва книги: " + TitleName);
        Console.ResetColor();
    }
}

class Author
{
    public string AuthorName { get; set; }

    public Author(string author)
    {
        AuthorName = author;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Автор: " + AuthorName);
        Console.ResetColor();
    }
}

class Content
{
    public string ContentText { get; set; }

    public Content(string content)
    {
        ContentText = content;
    }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Зміст: " + ContentText);
        Console.ResetColor();
    }
}

class Book
{
    public Title BookTitle { get; private set; }
    public Author BookAuthor { get; set; }
    public Content BookContent { get; set; }

    public Book(string title, string author, string content)
    {
        BookTitle = new Title(title);
        BookAuthor = new Author(author);
        BookContent = new Content(content);
    }

    public void Show()
    {
        BookTitle.Show();
        BookAuthor.Show();
        BookContent.Show();
    }
}

class Program
{
    static void Main()
    {
        Book book = new Book("Чорна рада", "Пантелеймона Куліша", "відтворено соціальні суперечності в Україні після переможної визвольної війни та приєднання до Московського царства...");
        book.Show();
    }
}
