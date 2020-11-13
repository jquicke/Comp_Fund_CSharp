using System;

class Fencepost
{
  public static void PrintLetters(string arg)
  {
    // write all letters of the string except the last one
    // (place all fence posts and connecting areas but last one)
    for (int index = 0;  index < arg.Length - 1;  index++)
    {
      Console.Write("{0}, ", arg[index]);
    }

    // last "half" loop iteration; write last letter
    if (arg.Length > 0)
      Console.Write(arg[arg.Length - 1]);

    Console.WriteLine();  // end the line once
  }
  
  static void Main()
  {
    PrintLetters("Mississippi");
  }
}