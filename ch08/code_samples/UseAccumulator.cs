using System;
using System.IO;

class UseAccumulator
{
  static void Main()
  {
    Accumulator accum = new Accumulator();
    StreamReader reader = new StreamReader("numbers.txt");
    
    // write an output header
    Console.WriteLine("{0,10}{1,10}{2,10}{3,10}",
                      "COUNT", "NUMBER", "SUM", "AVERAGE");
    Console.WriteLine(new string('=', 40));

    // read each line of input and write a summary line of output
    while (reader.Peek() != -1)
    {
      double number = double.Parse(reader.ReadLine());
      accum.Add(number);
      Console.WriteLine("{0,10}{1,10:F1}{2,10:F1}{3,10:F1}",
                        accum.Count, number, accum.Sum,
                        accum.Average);
    }
    
    reader.Close();
  }
}