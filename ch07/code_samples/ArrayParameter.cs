using System;

class ArrayParameter
{
  static void Main()
  {
    string[] strs = {"First", "Second", "Third", "Fourth"};
    PrintStaggered(strs);
  }

  static void PrintStaggered(string[] args)
  {
    string spacer = "";
    foreach (string arg in args)
    {
      Console.WriteLine("{0} {1}", spacer, arg);
      spacer += "  ";
    }
  }
}