using System;

// Adds numbers and reports the count, sum, and average.
class Accumulator
{
  private double sum;   // fields
  private int count;
  
  public Accumulator()
  {
    sum = 0.0;          // initialize fields
    count = 0;
  }

  // The sum of all the numbers accumulated so far.
  public double Sum
  {
    get { return sum; }
  }
  
  // The count of how many numbers have been accumulated.
  public int Count
  {
    get { return count; }
  }

  // Determine average; 0.0 when there are no numbers
  public double Average
  {
    get
    {
      if (count > 0)
        return sum / count;
      else                    // avoid division by zero
        return 0.0;
    }
  }

  // Add one number to this accumulator.
  public void Add(double number)
  {
    sum += number;
    count++;
  }
}