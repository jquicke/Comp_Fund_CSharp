using System;

// This class accumulates and averages numbers.
class Averager
{
  private int n = 0;
  double sum = 0.0;
  
  // Adds the given number to the running total.
  public void AddNumber(double num)
  {
    n++;
    sum += num;
  }
  
  // The current average of all numbers entered so far.
  public double Average
  {
    get
    {
      if (n == 0)
        return 0.0;
      else
        return sum / n;
    }
  }
}

// Demonstrates a determinate loop using the Averager class.
class TestAverage
{
  static void Main()
  {
    Averager averager = new Averager();

    Console.Write("How many numbers do you need to average? ");
    int n = int.Parse(Console.ReadLine());
    
    // Now accumulate n numbers
    for (int j = 0;  j < n;  j++)
    {
      // Repeat these statements n times
      Console.Write("Enter number: ");
      double input = double.Parse(Console.ReadLine());
      averager.AddNumber(input);
    }

    // Compute the average only when there is at least one input
    Console.WriteLine("Average of {0} numbers is {1:F1}", 
                      n, averager.Average);
  }
}