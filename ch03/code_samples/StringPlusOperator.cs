// Demonstrates overloaded string operator +
using System;

class StringPlusOperator
{
  static void Main()
  {
    string one = "one";
    string two = "two";
    string s_thirty = "30";
    int i_thirty = 30;
    
    Console.WriteLine("plus?         {0}", (one + two));
    Console.WriteLine("plus i30?     {0}", (one + i_thirty));
    Console.WriteLine("plus s30?     {0}", (one + s_thirty));
    Console.WriteLine("i30 plus i30? {0}", (i_thirty + i_thirty));
    Console.WriteLine("i30 plus s30? {0}", (i_thirty + s_thirty));
    Console.WriteLine("sixty?        {0}",
                     (i_thirty + i_thirty + one + two));
    Console.WriteLine("all?          {0}", 
                     (i_thirty + one + two + s_thirty));
  }
}

/*
plus?         onetwo
plus i30?     one30
plus s30?     one30
i30 plus i30? 60
i30 plus s30? 3030
sixty?        60onetwo
all?          30onetwo30
*/