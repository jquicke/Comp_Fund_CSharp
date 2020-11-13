// Demonstrates overloaded string operators ==, !=
using System;

class StringRelationalOperators
{
  static void Main()
  {
    string str1 = "hen";
    string str2 = "house";
    string str3 = "1234";
    string str4 = "henhouse";
    
    Console.WriteLine(str1 == "hen");
    Console.WriteLine(str1 != "HEN");
    Console.WriteLine(str1 + str2 == "HenHouse");
    Console.WriteLine(str4 == str1 + str2);
    Console.WriteLine(str4 == str2 + str1);
    Console.WriteLine(str4.Substring(0, 3) == str1);
    Console.WriteLine(1 + 23 + "4" == str3);
  }
}