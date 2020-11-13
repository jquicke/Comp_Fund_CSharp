using System;

class UseForeach
{
  static void Main()
  {
    int[] numbers = new int[4];
    numbers[0] = 42;
    numbers[1] = 10;
    numbers[2] = 8;
    numbers[3] = 1;
    
    foreach (int num in numbers)
    {
      Console.WriteLine("The element's value: {0}", num);
    }
  }
}