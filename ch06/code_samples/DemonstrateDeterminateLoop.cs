// Read n integers and display the range of inputs
using System;
public class DemonstrateDeterminateLoop
{
  static void Main()
  { 
    int aTemp;
    int n = 5;  // Only works with 5

    // Input first integer and record it as highest and lowest
    Console.WriteLine("Enter {0} numbers ", n);
    aTemp = int.Parse(Console.ReadLine());
    int highest = aTemp;
    int lowest = aTemp;

    // Process n inputs. Since the first was already
    // processed, start the loop counter at 2
    for (int j = 2; j <= n; j++)
    {
      // Get the next input
      aTemp = int.Parse(Console.ReadLine());

      // Update the highest so far, if necessary
      if (aTemp > highest)
        highest = aTemp;

      // Update the lowest so far, if necessary
      if (aTemp < lowest)
        lowest = aTemp;
    }

    int range = highest - lowest + 1;
    Console.WriteLine("Range: {0}", range);
  }
}