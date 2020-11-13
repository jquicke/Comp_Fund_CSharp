// This program computes and displays a final course grade as a
// weighted average after the user enters the appropriate input. 
using System;

class TestCourseGrade 
{ 
  static void Main()
  {
    // Declare the input and output variables
    double test1, test2, finalExam, courseGrade;
    

    Console.WriteLine("This program computes a course grade when");
    Console.WriteLine("you have entered three requested values.");
    Console.WriteLine();

    // I)nput test1, test2, and finalExam
    Console.Write("Enter first test: ");
    test1 = double.Parse(Console.ReadLine());

    Console.Write("Enter second test: ");
    test2 = double.Parse(Console.ReadLine());

    Console.Write("Enter final exam: ");
    finalExam = double.Parse(Console.ReadLine());
  
    // P)rocess 
    courseGrade = (0.25 * test1) + (0.25 * test2) + (0.50 * finalExam);

    // O)utput the results
    Console.WriteLine("Course Grade: {0}%", courseGrade);

  } // End of the Main method

} // End class TestCourseGrade