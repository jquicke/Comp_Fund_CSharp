using System;

class Compile timeErrors
{
  static void Main()
  {
    int pounds = 0;

    Console.WriteLine("Enter weight in pounds: ")
    pounds = int.Parse(Console.ReadLine);
    Console.WriteLine("In the U.K. you weigh {0 stone, {1}", 
                      Pounds / 14; pounds % 14); 
  }
}

/*
// The syntax errors have been fixed in this version.
class CompiletimeErrors
{
  static void Main()
  {
    int pounds = 0;
     
    Console.Write("Enter weight in pounds: "); 
    pounds = int.Parse(Console.ReadLine());
    Console.WriteLine("In the U.K. you weigh {0} stone, {1}", 
                      pounds / 14, pounds % 14); 
  }
}
*/