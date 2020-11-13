using System;

class HandleArrayIndices
{
  static void Main()
  {
    string[] names = new string[] {"Jane", null, "Mary"};
    Console.Write("Index? ");
    
    int index = int.Parse(Console.ReadLine());
    Console.WriteLine(names[index].ToUpper());
  }
}