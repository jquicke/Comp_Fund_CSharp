using System;

class TestStringIndexing
{
  static void Main()
  {
    string str1 = "Index this string!";
    string str2 = "Testing ";
    Console.WriteLine(str2);

    str2 = str2 + str1[8];    // the i in "this"
    str2 += str2[3];          // the t in "Testing"

    // string indexing produces a value of type char
    char lastLetter = str1[17];  // the ! mark
    str2 += lastLetter;

    Console.WriteLine(str2);
  }
}