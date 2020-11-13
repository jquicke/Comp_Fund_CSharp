using System;

// There are no syntax errors here
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