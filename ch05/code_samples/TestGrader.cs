using System;

class TestGrader
{
  static void Main()
  {
    CollegeStudent jim = new CollegeStudent("Jim", 1.7);

    Console.WriteLine(jim);  // calls ToString
    Console.WriteLine(jim.GetLetterGrade(-0.1));
    Console.WriteLine(jim.GetLetterGrade(0.0));
    Console.WriteLine(jim.GetLetterGrade(59.9));
    Console.WriteLine(jim.GetLetterGrade(60.0));
    Console.WriteLine(jim.GetLetterGrade(69.9));
    Console.WriteLine(jim.GetLetterGrade(70.0));
    Console.WriteLine(jim.GetLetterGrade(79.9));
    Console.WriteLine(jim.GetLetterGrade(80.0));
    Console.WriteLine(jim.GetLetterGrade(89.9));
    Console.WriteLine(jim.GetLetterGrade(90.0));
    Console.WriteLine(jim.GetLetterGrade(99.9));
    Console.WriteLine(jim.GetLetterGrade(100.0));
    Console.WriteLine(jim.GetLetterGrade(101.1));
  }
}