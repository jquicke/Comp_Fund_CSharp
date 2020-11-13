using System;

class UseSelectionSort
{
  static void Main()
  {
    // Build a small array to work with
    double[] data = { 76.0, 91.0, 100.0, 62.0, 89.0 };
    int n = data.Length;

    Console.Write("Before sorting: ");
    for(int j = 0; j < data.Length; j++)
      Console.Write(data[j] + " ");
    Console.WriteLine();

    int indexOfSmallest = 0;

    for(int top = 0; top < n - 1; top++)
    {
      // First assume that the smallest is 
      // the first element in the subarray
      indexOfSmallest = top;

      // compare all of the other elements, looking for smallest
      for(int index = top + 1; index < data.Length; index++)
      { // Compare elements in the subarray
        if(data[index] < data[indexOfSmallest])
          indexOfSmallest = index;
      }

      // make sure the smallest from data[top] through data.size
      // is in data[top]. This message swaps two array elements.
      double temp = data[top];  // Hold on to value temporarily
      data[top] = data[indexOfSmallest];
      data[indexOfSmallest] = temp;
    }

    Console.Write(" After sorting: ");
    for (int j = 0; j < data.Length; j++)
      Console.Write(data[j] + " ");
    Console.WriteLine();
  }
}