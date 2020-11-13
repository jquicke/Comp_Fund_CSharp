// Performs simple DateTime arithmetic.
using System;

class DateTimeArithmetic1
{
  static void Main()
  {
    DateTime dateOfPurchase = new DateTime(2004, 5, 22);
    // Move 90 days ahead
    dateOfPurchase = dateOfPurchase.AddDays(90);

    int year  = dateOfPurchase.Year;
    int month = dateOfPurchase.Month;
    int day   = dateOfPurchase.Day;
    Console.WriteLine("Warranty expires on {0}/{1}/{2}", 
                                       year, month, day);
  }
}