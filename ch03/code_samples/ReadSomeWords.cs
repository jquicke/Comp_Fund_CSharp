// Uses the Console class to read multiple input words on one line
using System;

class ReadSomeWords
{
  static void Main()
  {
    string name, firstName, lastName;       
    
    Console.Write("Enter your name: ");
    name = Console.ReadLine();
    
    // Break up the whole name into first and last name
    int indexOfSpace = name.IndexOf(" ");
    firstName = name.Substring(0, indexOfSpace);
    
    // Store characters from indexOfSpace+1 to end of string
    lastName = name.Substring(indexOfSpace + 1); 
   
    Console.WriteLine("Your name is: {0}", name);
    Console.WriteLine("Your first name is: {0}", firstName);
    Console.WriteLine("Your last name is: {0}", lastName);
  }
}