// This program is in the file named CommandLine.cs
using System;

class CommandLine
{
  static void Main(string[] args)
  {
    Console.WriteLine("Number of command line parameters = {0}",
                      args.Length);

    for (int index = 0; index < args.Length; index++)
    {
      Console.WriteLine("args[{0}]: {1}", index, args[index]);
    }
  }
}