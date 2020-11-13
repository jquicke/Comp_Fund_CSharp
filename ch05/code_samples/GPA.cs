using System;

class GPA
{
  static void Main()
  {
    Console.Write("Enter GPA: ");
    double GPA = double.Parse(Console.ReadLine());

    if (GPA >= 3.5)
    { // True part contains more than one statement in this block
      Console.WriteLine("Congrats, you are on the dean's list.");
      double margin = GPA - 3.5;
      Console.WriteLine("You made it by {0} points.", margin);
    }
    else
    { // False part contains more than one statement in this block
      Console.WriteLine("Sorry, you are not on the dean's list.");
      double margin = 3.5 - GPA;
      Console.WriteLine("You missed it by {0} points.", margin);
    } 
  }
}