using System;

class TestLibraryBook
{
  static void Main()
  {
    LibraryBook aBook = new LibraryBook("Early Bird", "Joist");

    Console.WriteLine("Main: Borrower is {0}", aBook.Borrower);
    aBook.Borrower = "Kim";
    Console.WriteLine("Main: Borrower is {0}", aBook.Borrower);
    aBook.Borrower = "---";
    Console.WriteLine("Main: Borrower is {0}", aBook.Borrower);
  }
}

public class LibraryBook
{
  private string title;
  private string author;
  private string borrower;
  
  public LibraryBook(string bookTitle, string bookAuthor)
  {
    title = bookTitle;
    author = bookAuthor;
    borrower = "---";
  }

  public string Borrower
  {
    get
    {
      Console.WriteLine("Getting borrower's value of {0}", 
                        borrower);
      return borrower;
    }
    set
    {
      Console.WriteLine("Setting borrower to {0}", value);
      borrower = value;
    }
  }
}