// Explores the properties of a DateTime object.
using System;

class DateTimeNowTest
{
  static void Main()
  {
    DateTime rightNow = DateTime.Now;
    Console.WriteLine("Now = {0}", rightNow);
    Console.WriteLine("Date = {0}", rightNow.Date);
    Console.WriteLine("Month = {0}", rightNow.Month);
    Console.WriteLine("Day = {0}", rightNow.Day);
    Console.WriteLine("Year = {0}", rightNow.Year);
    Console.WriteLine("Hour = {0}", rightNow.Hour);
    Console.WriteLine("Minute = {0}", rightNow.Minute);
    Console.WriteLine("Second = {0}", rightNow.Second);
  }
}