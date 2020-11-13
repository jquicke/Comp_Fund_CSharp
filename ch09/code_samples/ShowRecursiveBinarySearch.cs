using System;

// Demonstrate another recursive searching method
class ShowRecursiveBinarySearch
{
  // Return true if searchElement is found in array.
  public static bool Exists(string[] array, 
                            int first, int last,
                            string searchElement)
  {
    if (first > last)
      return false;       // Base case 1: Nothing left to search
    else
    {
      // There is at least one more element to compare
      int mid = (first + last) / 2;

      if (searchElement.Equals(array[mid]))
        return true;     // Base case 2: Found it
      else if (searchElement.CompareTo(array[mid]) < 0)
        // Recursive case 1
        return Exists(array, first, mid - 1, searchElement);
      else
        // Recursive case 2
        return Exists(array, mid + 1, last, searchElement);
    }
  }

  static void Main()
  {
    // Initialize an array so it is sorted.
    string[] array = { "Grant", "Jen", "Kelly", 
                       "Marty", "Mike", "Stuart" };
    int hi = array.Length - 1;

    Console.WriteLine("{0} =? True", Exists(array, 0, hi, "Mike"));
    Console.WriteLine("{0} =? True", Exists(array, 0, hi, "Grant"));
    Console.WriteLine("{0} =? False", Exists(array, 0, hi, "Not"));
  }
}