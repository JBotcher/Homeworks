using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
    public int CopiesAvailable { get; private set; }

    public Book(string title, string author, string isbn, int copiesAvailable)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
        CopiesAvailable = copiesAvailable > 0 ? copiesAvailable : 0;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Copies Available: {CopiesAvailable}");
    }

    public bool BorrowBook()
    {
        if (CopiesAvailable > 0)
        {
            CopiesAvailable--;
            return true;
        }
        Console.WriteLine("No copies available.");
        return false;
    }

    public void ReturnBook()
    {
        CopiesAvailable++;
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added.");
    }

    public void DisplayAllBooks()
    {
        foreach (var book in books)
            book.DisplayInfo();
    }

    public Book SearchBookByTitle(string title)
    {
        return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("1. Add Book\n2. Display All Books\n3. Search Book\n4. Borrow Book\n5. Return Book\n6. Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    Console.Write("Enter copies: ");
                    int copies = int.Parse(Console.ReadLine() ?? "0");
                    library.AddBook(new Book(title, author, isbn, copies));
                    break;

                case "2":
                    library.DisplayAllBooks();
                    break;

                case "3":
                    Console.Write("Enter title to search: ");
                    var book = library.SearchBookByTitle(Console.ReadLine());
                    if (book != null) book.DisplayInfo();
                    else Console.WriteLine("Book not found.");
                    break;

                case "4":
                    Console.Write("Enter title to borrow: ");
                    book = library.SearchBookByTitle(Console.ReadLine());
                    if (book != null && book.BorrowBook()) Console.WriteLine("Book borrowed.");
                    break;

                case "5":
                    Console.Write("Enter title to return: ");
                    book = library.SearchBookByTitle(Console.ReadLine());
                    if (book != null) { book.ReturnBook(); Console.WriteLine("Book returned."); }
                    break;

                case "6":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
