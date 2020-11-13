using System;

class TestGradeTable
{
  static void Main()
  {
    int numRows = int.Parse(Console.ReadLine());
    int numCols = int.Parse(Console.ReadLine());

    GradeTable table = new GradeTable(numRows, numCols);

    // initialize the data in the table
    for (int row = 0;  row < numRows;  row++)
    {
      for (int col = 0;  col < numCols;  col++)
      {
        double score = double.Parse(Console.ReadLine());
        table.SetScore(row, col, score);
      }
    }

    Console.WriteLine(table);         // uses ToString method
    table.PrintStudentStatistics();
    table.PrintAssignmentStatistics();
    Console.WriteLine("Assignment Average: {0:F1}", 
      table.GetAssignmentAverage());
  }
}