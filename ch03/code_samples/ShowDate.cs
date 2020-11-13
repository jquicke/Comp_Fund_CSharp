// Shows properties of a DateTime object.
using System;

class ShowDate
{
  static void Main()
  {
    DateTime aDay = new DateTime(2004, 5, 22);

    int year  = aDay.Year;
    int month = aDay.Month;
    int day   = aDay.Day;
    Console.WriteLine("Day {0} of month {1} of the year {2}", 
                       day, month, year);
  }
}