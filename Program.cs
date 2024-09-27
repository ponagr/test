using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        var book1 = new Book("Harry Potter", "J.K Rowling");
        book1.Print();
    }
}

class Book
{   
    string title;
    string author;
    
    public Book(string title, string author)
    {
        this.title = title;
        this.author = author;
    }

    public void Print()
    {
        Console.Write($"Title: {title}, Author: {author}");
    }
}
