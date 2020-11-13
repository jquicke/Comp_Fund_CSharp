// Uses the DateTime.Now property to display the current date.
using System;

class ShowToday
{
  static void Main()
  {
    DateTime rightNow = DateTime.Now;    // The current date and time

    int year  = rightNow.Year;
    int month = rightNow.Month;
    int day   = rightNow.Day;
    Console.WriteLine("Today is {0}/{1}/{2}", year, month, day);
  }
}