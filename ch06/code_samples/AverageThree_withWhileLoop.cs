using System;

class AverageThree
{
  static void Main()
  {
    double sum = 0.0;   // stores the sum of all inputs
    double input;       // will be read many times below

    int numIterations = 3;
    int i = 0;
    
    while (i < numIterations)
    {
      // The following statements will be repeated 3 times.
      Console.Write("Enter number: "); 
      input = double.Parse(Console.ReadLine());
      sum += input;
      
      i++;
    }

    double average = sum / numIterations;
    Console.WriteLine("Average: {0}", average);
  }
}