using System;

// Build a class to demonstrate a class with an array field
public class QuizScores
{
  // Fields
  private int[] quiz;  // The array is declared, but not constructed
  private int size;    

  // Build an empty list of 
  public QuizScores()
  {
    quiz = new int[100];
    size = 0;
  }

  // Place the new quiz score as the last element in the array
  public void Add(int aQuiz)
  {
    quiz[size] = aQuiz;
    size++;
  }

  // Determine the average of all quiz scores so far.
  // Return -1.0 when there are no quizzes to average.
  public double Average()
  {
    // Find sum
    double sum = 0.0;
    for (int index = 0; index < size; index++)
    {
      sum += quiz[index];
    }

    // Return average or -1 if no quizzes have been added yet.
    if(size == 0)
      return -1.0;
    else
      return (sum/size);
  }

  // for testing
  static void Main()
  {
    QuizScores quiz1 = new QuizScores();
    QuizScores quiz2 = new QuizScores();

    // Add a few quiz scores to the first quiz
    quiz1.Add(90);
    quiz1.Add(84);
    quiz1.Add(80);

    // Add a couple of quiz scores to the second quiz
    quiz2.Add(100);
    quiz2.Add(82);

    Console.WriteLine("Average for quiz 1 {0:F1}", quiz1.Average());
    Console.WriteLine("Average for quiz 2 {0:F1}", quiz2.Average());
  }

} // End class QuizScores