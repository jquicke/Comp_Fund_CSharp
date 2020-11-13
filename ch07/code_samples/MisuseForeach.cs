using System;

class MisuseForeach
{
  static void Main()
  {
    // find the smallest element value; expected result is 2
    int[] numbers = new int[10];
    numbers[0] = 15;
    numbers[1] = 2;
    numbers[2] = 29;
    numbers[3] = 101;

    int smallest = numbers[0];

    foreach (int element in numbers)
    {
      if (element < smallest)
        smallest = element;
    }

    Console.WriteLine("Smallest number in the array is {0}", 
                      smallest);
  }
}