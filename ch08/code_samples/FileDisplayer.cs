// Displays a file with line numbers on each line.
using System;
using System.IO;

class FileDisplayer
{
  static void Main(string[] args)
  {
    if (args.Length == 0)
      Console.WriteLine("Usage: FileDisplayer [file-name]");
    else
    {
      // open the file
      string filename = args[0];
      StreamReader reader = new StreamReader(filename);

      int lineNum = 1;
      while (reader.Peek() != -1)
      {
        // read a line
        string line = reader.ReadLine();
        
        // write the line with a line number at the start
        Console.WriteLine("{0,3} {1}", lineNum, line);
        lineNum++;
      }
    }
  }
}