using System;

class ArrayParameter2
{
  static void Main()
  {
    string[] strs = {"First", "Second", "Third", "Fourth"};
    PrintStaggered(strs);
    Capitalize(strs);
    PrintStaggered(strs);
  }

  // Makes all strings in the given array be upper case.
  static void Capitalize(string[] args)
  {
    for (int index = 0; index < args.Length; index++)
      args[index] = args[index].ToUpper();
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