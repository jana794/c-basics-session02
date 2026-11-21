using System;

class Book
{
    public string Title;
    public int Pages;

    public Book(string title, int pages)
    {
        Title = title;
        Pages = pages;
    }

    public override string ToString()
    {
        return "Title: " + Title + ", Pages: " + Pages;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Q01");
        Book book = new Book("C# Basics", 464);
        Console.WriteLine(book);


        Console.WriteLine("\nQ02");
        Console.WriteLine(book.ToString());
        Console.WriteLine(book.Equals(book));
        Console.WriteLine(book.GetHashCode());
        Console.WriteLine(book.GetType());


        Console.WriteLine("\nQ03");
        int pages = 464;
        Console.WriteLine(pages);


        Console.WriteLine("\nQ04");
        try
        {
            int x = 10;
            int y = 0;
            int result = x / y;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        Console.WriteLine("Done");


        Console.WriteLine("\nQ05");
        int pagesCount = 300;
        double number = pagesCount;
        Console.WriteLine(number);


        Console.WriteLine("\nQ06");
        double price = 49.99;
        int newPrice = (int)price;
        Console.WriteLine(newPrice);


        Console.WriteLine("\nQ07");
        string pagesText = "464";
        int convertedPages = Convert.ToInt32(pagesText);
        Console.WriteLine(convertedPages);


        Console.WriteLine("\nQ08");
        string yearText = "2023";
        int year = int.Parse(yearText);
        Console.WriteLine(year);

        string badText = "abc";
        int badNumber;

        if (int.TryParse(badText, out badNumber))
        {
            Console.WriteLine(badNumber);
        }
        else
        {
            Console.WriteLine("Invalid number");
        }


        Console.WriteLine("\nQ09");
        int pagesNumber = 464;
        string text = pagesNumber.ToString();
        Console.WriteLine(text);
        Console.WriteLine(text.GetType());


        Console.WriteLine("\nQ10");
        int copies = 100;
        object obj = copies;
        int newCopies = (int)obj;

        Console.WriteLine(obj);
        Console.WriteLine(newCopies);
    }
}