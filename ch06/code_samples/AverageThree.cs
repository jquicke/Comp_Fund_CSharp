using System;

class AverageThree
{
  static void Main()
  {
    double sum = 0.0;   // stores the sum of all inputs
    double input;       // will be read many times below

    // The following statements will be repeated several times.
    Console.Write("Enter number: "); 
    input = double.Parse(Console.ReadLine());
    sum += input;

    Console.Write("Enter number: ");
    input = double.Parse(Console.ReadLine());  
    sum += input;

    Console.Write("Enter number: ");
    input = double.Parse(Console.ReadLine());  
    sum += input;

    double average = sum / 3.0;
    Console.WriteLine("Average: {0}", average);
  }
}