using System;
using System.Collections.Generic;
using System.Text;

class Author
{
    public string Name { get; }

    public Author(string name)
    {
        Name = name;
    }
}

class Book
{
    public Author Author { get; }
    public string Title { get; }

    public Book(Author author, string title)
    {
        Author = author;
        Title = title;
    }

    public override string ToString()
    {
        return $"{Author.Name}, {Title}";
    }
}

class Shelf
{
    private int Floor { get; }
    private int Closet { get; }
    private Book[,,] Books { get; }

    public Shelf(int floor, int closet)
    {
        Floor = floor;
        Closet = closet;
        Books = new Book[floor, closet, 6];
    }

    public void Add(Book book, int floor, int closet, int javon)
    {
        if (Books[floor, closet, javon] == null)
        {
            Books[floor, closet, javon] = book;
        }
    }

    public bool Contains(Book book, int floor, int closet, int javon)
    {
        return book.Equals(Books[floor, closet, javon]);
    }

    public string GetBooks()
    {
        StringBuilder result = new StringBuilder();
        for (int f = 0; f < Floor; f++)
        {
            result.AppendLine($"Shelf {f + 1}");
            for (int c = 0; c < Closet; c++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Books[f, c, j] != null)
                    {
                        result.AppendLine(Books[f, c, j].ToString());
                    }
                }
            }
        }
        return result.ToString();
    }

    public int GetFloor(Book book)
    {
        for (int f = 0; f < Floor; f++)
        {
            for (int c = 0; c < Closet; c++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (book.Equals(Books[f, c, j]))
                    {
                        return f + 1;
                    }
                }
            }
        }
        return -1;
    }

    public int GetCloset(Book book)
    {
        for (int f = 0; f < Floor; f++)
        {
            for (int c = 0; c < Closet; c++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (book.Equals(Books[f, c, j]))
                    {
                        return c + 1;
                    }
                }
            }
        }
        return -1;
    }

    public int GetShelf(Book book)
    {
        for (int f = 0; f < Floor; f++)
        {
            for (int c = 0; c < Closet; c++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (book.Equals(Books[f, c, j]))
                    {
                        return j + 1;
                    }
                }
            }
        }
        return -1;
    }

    public Book Find(string authorName, string title)
    {
        for (int f = 0; f < Floor; f++)
        {
            for (int c = 0; c < Closet; c++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (Books[f, c, j] != null && Books[f, c, j].Author.Name.Equals(authorName)
                        && Books[f, c, j].Title.Equals(title))
                    {
                        return Books[f, c, j];
                    }
                }
            }
        }
        return null;
    }
}

class Library
{
    private Shelf[] Shelves { get; }

    public Library()
    {
        Shelves = new Shelf[]
        {
            new Shelf(3, 30),
        };
    }

    public void AddBook(Book book, int shelf, int floor, int closet, int javon)
    {
        Shelves[shelf - 1].Add(book, floor - 1, closet - 1, javon - 1);
    }

    public bool ContainsBook(Book book, int shelf, int floor, int closet, int javon)
    {
        return Shelves[shelf - 1].Contains(book, floor - 1, closet - 1, javon - 1);
    }

    public string GetBooks()
    {
        StringBuilder result = new StringBuilder();
        foreach (Shelf shelf in Shelves)
        {
            result.Append(shelf.GetBooks());
        }
        return result.ToString();
    }

    public int GetFloor(Book book)
    {
        foreach (Shelf shelf in Shelves)
        {
            int floor = shelf.GetFloor(book);
            if (floor != -1)
            {
                return floor;
            }
        }
        return -1;
    }

    public int GetCloset(Book book)
    {
        foreach (Shelf shelf in Shelves)
        {
            int closet = shelf.GetCloset(book);
            if (closet != -1)
            {
                return closet;
            }
        }
        return -1;
    }

    public int GetShelf(Book book)
    {
        foreach (Shelf shelf in Shelves)
        {
            int javon = shelf.GetShelf(book);
            if (javon != -1)
            {
                return javon;
            }
        }
        return -1;
    }

    public Book FindBook(string authorName, string title)
    {
        foreach (Shelf shelf in Shelves)
        {
            Book book = shelf.Find(authorName, title);
            if (book != null)
            {
                return book;
            }
        }
        return null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Author author1 = new Author("Author1");
        Author author2 = new Author("Author2");

        Book book1 = new Book(author1, "Title1");
        Book book2 = new Book(author2, "Title2");

        Library library = new Library();

        library.AddBook(book1, 1, 1, 1, 1);
        library.AddBook(book2, 2, 2, 2, 2);

        Console.WriteLine(library.GetBooks());

        Console.WriteLine("Floor: " + library.GetFloor(book1));
        Console.WriteLine("Closet: " + library.GetCloset(book1));
        Console.WriteLine("Shelf: " + library.GetShelf(book1));

        Book foundBook = library.FindBook("Author2", "Title2");
        if (foundBook != null)
        {
            Console.WriteLine("Found book: " + foundBook.ToString());
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }
}
