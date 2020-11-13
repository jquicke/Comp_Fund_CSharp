using System;

class Options
{
  static void Main()
  {
    Console.Write("Add Remove Print: ");

    // Choose from 1 of 3 valid selections or report an invalid option.
    // Make sure the string has no leading or trailing blanks 
    // that it is also in upper case (easier on the user).
    string option = Console.ReadLine().Trim().ToUpper();  

    // Choose from 1 of 3 options or report an invalid option.
    switch (option)
    {
      case "ADD":
        Console.WriteLine("Add selected");
        break;
      case "REMOVE":
        Console.WriteLine("Remove selected");
        break;
      case "PRINT":
        Console.WriteLine("Print selected");
        break;
      default:
        Console.WriteLine("Invalid choice");
        break;
    } // End switch
  }
}