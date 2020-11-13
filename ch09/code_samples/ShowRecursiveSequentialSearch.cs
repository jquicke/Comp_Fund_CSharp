using System;

// Demonstrate a recursive searching method
class ShowRecursiveSequentialSearch
{
  public static bool Exists(string[] array, 
                            int lastIndex, 
                            string searchElement)
  {
    if (lastIndex < 0)
      return false;   // Base case 1: Nothing left to search
    else if (array[lastIndex] == searchElement)
      return true;    // Base case 2: Found it
    else
      // Recursive case
      return Exists(array, lastIndex - 1, searchElement);
  }

  static void Main()
  {
    string[] array = {"Kelly", "Mike", "Jen", 
                      "Marty", "Stuart", "Grant"};
    int n = array.Length - 1;

    Console.WriteLine("{0} =? True", Exists(array, n, "Kelly"));
    Console.WriteLine("{0} =? True", Exists(array, n, "Jen"));
    Console.WriteLine("{0} =? False", Exists(array, n, "Not"));
  }
}