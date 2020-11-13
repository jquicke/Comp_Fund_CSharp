using System;

public class ShowTAs
{
  static void Main()
  {
    string[] TAs = {
      "Kelly Heffner", "Barney Boisvert", "*Canceled*",
      "Chris Schulte", "*Canceled*", "Stuart Smith",
      "Andy Lenards", "Brent Haas", "Stuart Smith"
    };

    Console.WriteLine("CS227 TAs for {0} sections", TAs.Length);
    Console.WriteLine("Sec#  TA name");
    Console.WriteLine("====  ==============");
    for (int j = 0; j < TAs.Length; j++)
    {
      Console.WriteLine(" #{0}   {1}", (j + 1), TAs[j]);
    }
  }
}