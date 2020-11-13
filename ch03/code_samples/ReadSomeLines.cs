// Uses the Console class's ReadLine method to read strings.
using System;

class ReadSomeLines
{
  static void Main()
  {  
    string firstName, address;

    Console.Write("Enter first name: ");
    firstName = Console.ReadLine();

    Console.Write("Enter address: ");
    address = Console.ReadLine();
 
    Console.WriteLine("Hello {0}, do you really live at {1}?",
                      firstName, address);
  }
}