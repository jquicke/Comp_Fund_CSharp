using System;

class WriteArguments
{
  static void Main(string[] args)
  {
    foreach (string arg in args)
    {
      Console.WriteLine("argument: {0}", arg);
    }
  }
}