using System;

class TestLibraryBook
{
  static void Main()
  {
    LibraryBook aBook = new LibraryBook("Early Bird", "Joist");
    LibraryBook anotherBook = new LibraryBook("Night Hawk", 
                                              "Floris");
  }
}

///////////////////////////////////////////////////////////////
// This LibraryBook is built in subsequent self check questions
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
    Console.WriteLine("'{0}' by {1}",
                      title, author);
  }
}