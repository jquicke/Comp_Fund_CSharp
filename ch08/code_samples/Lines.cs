using System;
class Lines
{
  static void Main()
  {
    int lines1 = CountLines("file1.txt");
    int lines2 = CountLines("file2.txt");
    Console.WriteLine("# of lines in file 1 = {0}", lines1);
    Console.WriteLine("# of lines in file 2 = {0}", lines2);
  }
}