// Demonstrate formatted strings with format specifiers.
using System;

class DemonstrateFormatting
{
  static void Main()
  {
    double d = 1472.59;
    int n = 676685;
    
    Console.WriteLine("The many formats of {0} and {1}:", d, n);
    Console.WriteLine("---------------------------------");

    Console.WriteLine("{0:C}   {0:E2}   {0:F3}", d);
    Console.WriteLine("{0:G4}  {0:N}   {0:P0}", d);
    Console.WriteLine("{0:D}   {0:N}   {0:X8}", n);
  }
}