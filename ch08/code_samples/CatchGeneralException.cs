// Catches any exception that occurs. (bad design)
using System;

class CatchGeneralException
{
  static void Main()
  {
    string[] names = new string[] {"Jane", null, "Mary"};
    Console.Write("Index? ");

    try
    {
      // read a number and try to print that array element
      int index = int.Parse(Console.ReadLine());
      Console.WriteLine(names[index].ToUpper());
    }
    catch (Exception ex)   // catch ANY error that happens
    {
      Console.WriteLine("An error occurred: {0}", ex.Message);
    }
  }
}