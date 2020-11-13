// Shows handling multiple exceptions in one try block.
using System;

class MultipleExceptions
{
  static void Main()
  {
    int[] numberArray = {1, 2, 3, 0, 4, 5};
    string line = null;
    
    try
    {
      // read two indices
      Console.Write("Enter a first index: ");
      line = Console.ReadLine();
      int index1 = int.Parse(line);

      Console.Write("Enter a second index: ");
      line = Console.ReadLine();
      int index2 = int.Parse(line);

      // do some math on the array, and write the answer
      int result = numberArray[index1] / numberArray[index2];
      Console.WriteLine("Result of division is: {0}", result);
    }
    catch (FormatException fe)
    { // execute this code if the string is not a number
      Console.WriteLine("Error: Invalid number entered: {0}", 
                        line);
      Console.WriteLine(fe.Message);
    }
    catch (IndexOutOfRangeException ioore)
    { // execute this code if the numberArray[index] is bad
      Console.WriteLine("Error: Invalid index.");
      Console.WriteLine(ioore.Message);
    }
    catch (DivideByZeroException dbze)
    { // execute this code if numberArray[3] is the denominator
      Console.WriteLine("Error: division by zero!");
      Console.WriteLine(dbze.Message);
    }
  }
}