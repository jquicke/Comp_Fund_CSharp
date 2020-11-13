using System;

class TestLibraryBook
{
  static void Main()
  {
    LibraryBook aBook = new LibraryBook("Early Bird", "Joist");

    Console.WriteLine(aBook);  // calls ToString
    aBook.BorrowBook("Kim");

    Console.WriteLine(aBook);  // calls ToString
    Console.ReadLine();
  }
}

// LibraryBook continues to grow in the self check questions
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
  }

  public void ReturnBook()
  {
    borrower = "---";
  }

  public override string ToString()
  {
    return string.Format("'{0}', by {1}, borrowed by {2}",
                         title, author, borrower);
  }
}