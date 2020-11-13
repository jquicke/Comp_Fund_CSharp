// Writes some data to a file using a StreamWriter.
using System;
using System.IO;

class WriteToFile
{
  static void Main()
  {
    StreamWriter writer = new StreamWriter("output.txt");
    writer.Write("Here is a line of text.\n");
    writer.Write("\n");    // need \n to move to next line
    writer.Write("That last one was a blank line!\n");
    writer.Write(string.Format("A format string: {0:C} {1:F2}\n", 
                                2.0, 1.234));
    writer.Write("This is the end of the file.");
    writer.Close();
  }
}