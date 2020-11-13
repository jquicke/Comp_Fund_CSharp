using System;

class Alphabits
{
  static void Main()
  {
    string a = "Able";
    string b = "Baker";

    if (a.CompareTo("Charlie") < 0)
      Console.WriteLine("{0} < Charlie", a);

    if (a.CompareTo(b) > 0)
      Console.WriteLine("{0} > {1}", a, b);

    if (b.CompareTo(a) > 0)  // False
      Console.WriteLine("{0} > {1}", b, a);

    if (b.CompareTo(b) == 0)
      Console.WriteLine("{0} equals {0}", b);
  }
}