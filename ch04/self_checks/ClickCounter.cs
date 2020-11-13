using System;
class ClickCounter
{
  public static readonly int START_COUNT = 0;
  private int count;
  private int maxCount;

  // Constructer 
  public ClickCounter(int init_maxCount) 
  { 
    count = START_COUNT;
    maxCount = init_maxCount; 
  }

  // Change the count of this clickCounter. 
  // If at maximum, reset to 0, otherwise add 1
  public void Click()
  { 
    count = (count + 1) % (maxCount + 1);
  }

  // Evaluate to this clickCounter's count 
  public int Count 
  { 
    get
    { // Return the count of this ClickCounter     
      return count;
    }
  }

  static void Main()
  {
    // aCounter only counts from 0 to 3
    ClickCounter aCounter = new ClickCounter(3);
    
    Console.WriteLine(aCounter.Count);
    aCounter.Click();
    Console.WriteLine(aCounter.Count);
    aCounter.Click();
    Console.WriteLine(aCounter.Count);
    aCounter.Click();
    Console.WriteLine(aCounter.Count);
    aCounter.Click();
    Console.WriteLine(aCounter.Count);
    aCounter.Click();
    Console.WriteLine(aCounter.Count);
  }
}