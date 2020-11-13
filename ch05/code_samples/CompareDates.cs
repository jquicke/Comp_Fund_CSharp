using System;

class CompareDates
{
  static void Main()
  {
    DateTime date1 = new DateTime(2003, 6, 1);
    DateTime date2 = new DateTime(2000, 12, 20);
    DateTime now   = DateTime.Now;   // current date and time
    
    if (date1.CompareTo(date2) >= 0)
      Console.WriteLine("{0} is equal to or after {1}",
                        date1, date2);
    
    if (now.CompareTo(date2) < 0)
      Console.WriteLine("Today's date must be before {0}", date2);
    else
      Console.WriteLine("It must be almost holiday break time!");
  }
}