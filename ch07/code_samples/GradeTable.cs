using System;

class GradeTable
{
  private double[,] scores;
  private int numRows, numCols;
  
  // Constructs a grade table holding the given number of rows 
  // (students) and the given number of columns (assignments).
  public GradeTable(int nrows, int ncols)
  {
    numRows = nrows;
    numCols = ncols;
    scores = new double[numRows, numCols];
  }
  
  // Returns the score for the given row (student) on the given 
  // column (assignment).
  public double GetScore(int row, int col)
  {
    return scores[row, col];
  }
  
  // Sets the score for the given row (student) on the given 
  // column (assignment) to be the given value.
  public void SetScore(int row, int col, double value)
  {
    scores[row, col] = value;
  }
  
  public override string ToString()
  {
    string result = "    ";
    
    // a header with the assignment numbers
    for (int col = 0;  col < numCols;  col++)
    {
      result += string.Format("{0,7}", col);
    }
    result += "\n";  // end of line

    // each student's scores
    for (int row = 0;  row < numRows;  row++)
    {
      // a header showing the student number
      result += string.Format("{0,4}", row);
      
      for (int col = 0;  col < numCols;  col++)
      {
        double score = GetScore(row, col);
        result += string.Format("{0,7:F1}", score);
      }
      
      result += "\n";  // end of line
    }
    
    result += "\n";  // one final blank line
    return result;
  }
  
  // Prints all students quiz averages.
  // This is an example of row-by-row processing.
  public void PrintStudentStatistics()
  {
    Console.WriteLine("Student    Average");
    Console.WriteLine("==================");

    for (int row = 0;  row < numRows;  row++)
    {
      // outer loop; iterates over all students (row processing)
      double sum = 0.0;

      for (int col = 0;  col < numCols;  col++)
      {
        // inner loop; calculates sum for this student
        sum += GetScore(row, col);
      }

      double average = sum / numCols;
      Console.WriteLine("{0,7}{1,11:F1}", row, average);
    }
    Console.WriteLine();
  }
  
  // Prints stats about each assignment, including the high, 
  // low and average score on it.
  // Precondition: numberOfQuizzes > 1
  // This is an example of column-by-column processing.
  public void PrintAssignmentStatistics()
  {
    Console.WriteLine("Assignment   High    Low   Average");
    Console.WriteLine("==================================");

    for (int col = 0;  col < numCols;  col++)
    {
      // outer loop; iterates over all assignments
      // (column processing)
      
      // initialize the high and low marks to the first entry
      // (assumes there is at least one student)
      double low = GetScore(0, col);
      double high = low;
      double sum = low;

      for (int row = 1;  row < numRows;  row++)
      {
        // inner loop; calculates sum for this student
        double score = GetScore(row, col);
        sum += score;
        if (score < low)
          low = score;
        else if (score > high)
          high = score;
      }

      double average = sum / numRows;
      Console.WriteLine("{0,10}{1,7:F1}{2,7:F1}{3,10:F1}", col, high, low, average);
    }    
    Console.WriteLine();
  }
  
  public double GetAssignmentAverage()
  {
    double sum = 0.0;
    for (int row = 0;  row < numRows;  row++)
    {
      for (int col = 0;  col < numCols;  col++)
      {
        sum += GetScore(row, col);
      }
    }

    double average = sum / (numRows * numCols);
    return average;
  }
}