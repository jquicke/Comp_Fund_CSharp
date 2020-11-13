// Demonstrates more date arithmetic and DateTime.Parse method:
using System;

class DateTimeArithmetic2
{
  static void Main()
  {
    int years, days;
    string startDateStr;
    DateTime date;
    
    // prompt user to enter a date
    Console.WriteLine("It's the amazing time machine!");
    Console.Write("What date would you like to start from? ");
    
    // read date and convert to a DateTime object
    startDateStr = Console.ReadLine();
    date = DateTime.Parse(startDateStr);
    
    // prompt user for time to travel
    Console.Write("How many years would you like to travel? ");
    years = int.Parse(Console.ReadLine());
    
    Console.Write("And how many days? ");
    days = int.Parse(Console.ReadLine());
    
    // perform some date arithmetic (modify and reassign)
    date = date.AddYears(years);
    date = date.AddDays(days);
    
    Console.WriteLine();
    Console.WriteLine("POOF! The date is now {0}", date);
  }
}