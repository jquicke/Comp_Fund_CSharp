using System;
using System.IO;   // For StreamReader

// This file is on the accompanying disk
class ObstacleCourse
{
  private static readonly char TRIED = '.';
  private static readonly char PART_OF_PATH = 'O';

  private char[,] course;
  private int startRow;
  private int startColumn;
  private int rows;
  private int columns;

  public ObstacleCourse(string fileName)
  {
    StreamReader obstacleCourseFile = new StreamReader(fileName);

    rows = int.Parse(obstacleCourseFile.ReadLine());
    columns = int.Parse(obstacleCourseFile.ReadLine());

    course = new char[rows, columns];
    for(int r = 0; r < rows; r++)
    {
      string line = obstacleCourseFile.ReadLine();
      for(int c = 0; c < columns; c++)
      {
        course[r, c] = line[c];
        if(course[r, c] == 'S')
        {
          startRow = r;
          startColumn = c;
          // Need to make this space available as part of a path.
          // The ToString method will substitute the S back in.
          course[r, c] = ' ';
        }
      }
      obstacleCourseFile.ReadLine();
    }
  }

  public override string ToString()
  {
    string result = "";
    for(int r = 0; r < rows; r++)
    {
      for(int c = 0; c < columns; c++)
      {
        if(course[r, c] == TRIED)
          result += ' ';
        else
          result += course[r, c];
      }
      result += '\n';
    }
    return result;
  }
}

class TestObstacleCourse
{
  // Write boolean TryThisWay and any private helper methods 
  // inside this class

  static void Main()
  {
    ObstacleCourse aCourse = 
            new ObstacleCourse("maze.dat");

    Console.WriteLine(aCourse);

    // Call method that calls your private method MarkPathToExit
    bool foundExit = aCourse.MarkPathToExit();

    if (!foundExit)
      Console.WriteLine("Could not solve");

    Console.WriteLine(aCourse);
  }
}