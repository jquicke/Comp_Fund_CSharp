using System;
using System.IO;

class ReadEntireFile
{
  static void Main()
  {
    // open a stream reader to read the file
    StreamReader reader = new StreamReader("input.txt");
    
    // keep track of line numbers
    int lineNum = 1;

    // read each line from the file and print it with its number
    while (reader.Peek() != -1)
    {
      string line = reader.ReadLine();
      Console.WriteLine("Line {0}: {1}", lineNum, line);
      lineNum++;
    }
    
    // done reading; close the file
    reader.Close();
  }
}