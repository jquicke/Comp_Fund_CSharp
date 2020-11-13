// Display some output using the Console class
using System;

class WriteSomeConsoleOutput
{
  static void Main()
  {
    int ID = 5678;
    double salary = 8.50;
    
    Console.WriteLine("Welcome to my program!");

    Console.Write(2.5);
    Console.Write(42);
    Console.Write("ID");
    Console.WriteLine("all on one line.");

    Console.Write("Your ID is "); 
    Console.Write(ID); 
    Console.Write(" and your salary is ");
    Console.WriteLine(salary);
  }
}