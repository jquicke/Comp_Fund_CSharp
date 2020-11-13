using System;

class TestLibraryBook
{
  static void Main()
  {
    LibraryBook aBook = new LibraryBook("Early Bird", "Joist");
    LibraryBook aBook2 = new LibraryBook("Night Hawk", "Flo");

    aBook.BorrowBook("Chris");
    aBook.ReturnBook();
    
    aBook2.BorrowBook("Kim");
    aBook2.ReturnBook();

    Console.ReadLine();
  }
}

// This LibraryBook will be built in subsequent self-checks
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
    get { return borrower; }
  }

  public void BorrowBook(string borrowerName)
  {
    borrower = borrowerName;
    Console.WriteLine("{0} borrows '{1}'", borrower, title);
  }

  public void ReturnBook()
  {
    Console.WriteLine("{0} returns '{1}'", borrower, title);
    borrower = "---";
  }
}