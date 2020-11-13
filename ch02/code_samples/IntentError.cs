using System;

// Find the average given the sum and the size of a set of numbers
class IntentError
{
  static void Main()
  {
    double sum = 0.0;
    double average = 0.0;
    int number = 0;

    // Input:
    Console.Write("Enter sum: ");
    sum = double.Parse(Console.ReadLine());
    Console.Write("Enter number: ");
    number = int.Parse(Console.ReadLine());

    // Process
    average = number / sum;

    // Output
    Console.WriteLine("Average: {0}", average);
  }
}