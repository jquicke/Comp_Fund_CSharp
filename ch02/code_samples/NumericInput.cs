// Reads an int and a double from the keyboard.
using System;

class NumericInput
{
  static void Main()
  {
    int credits;
    double qualityPoints;

    // User inputs an integer, which gets stored in credits
    Console.Write("Enter credits: ");
    credits = int.Parse(Console.ReadLine());

    // User inputs a double, which gets stored in qualityPoints
    Console.Write("Enter quality points: ");
    qualityPoints = double.Parse(Console.ReadLine());

    // Calculate GPA and write results on screen
    double GPA = qualityPoints / credits;
    Console.WriteLine("Credits completed: {0} total", credits);
    Console.WriteLine("You have {0} quality points", 
                      qualityPoints);
    Console.WriteLine("GPA is {0}", GPA);
  }
}