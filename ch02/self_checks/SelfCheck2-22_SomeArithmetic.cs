// This class is used in Self-Check 2-22.
using System;

class SomeArithmetic
{
  static void Main()
  { // Declare several numeric variables
    double c1, c2, g1, g2, GPA;

    // I)nput
    Console.Write("Credits for course 1: ");
    c1 = double.Parse(Console.ReadLine());
    Console.Write("Grade for course 1: ");
    g1 = double.Parse(Console.ReadLine());
    Console.Write("Credits for course 2: ");
    c2 = double.Parse(Console.ReadLine());
    Console.Write("Grade for course 2: ");
    g2 = double.Parse(Console.ReadLine());

    // P)rocess
    GPA = ((c1 * g1) + (c2 * g2)) / (c1 + c2);

    // O)utput
    Console.WriteLine("GPA: {0}", GPA);
  }
}