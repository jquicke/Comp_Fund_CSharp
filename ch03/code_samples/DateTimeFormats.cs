// Demonstrates date/time format specifiers.
using System;

class DateTimeFormats
{
  static void Main()
  {
    DateTime date = DateTime.Now;
    
    Console.WriteLine("  = {0}", date);
    Console.WriteLine("d = {0:d}", date);
    Console.WriteLine("D = {0:D}", date);
    Console.WriteLine("f = {0:f}", date);
    Console.WriteLine("F = {0:F}", date);
    Console.WriteLine("g = {0:g}", date);
    Console.WriteLine("G = {0:G}", date);
    Console.WriteLine("M = {0:M}", date);
    Console.WriteLine("t = {0:t}", date);
    Console.WriteLine("T = {0:T}", date);
    Console.WriteLine("Y = {0:Y}", date);
  }
}