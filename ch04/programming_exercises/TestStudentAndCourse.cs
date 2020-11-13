using System;
class TestStudentAndCourse
{
  // This is a test class for Course and Student;
  // Constructs one Student object and try every method and property.
  static void Main()
  {
    // Test Student
    Student s1 = new Student("Devon"); // No courses yet
    Console.WriteLine(s1.ToString());
    Console.WriteLine("Name: {0}", s1.Name);
    Console.WriteLine(" GPA: {0}", s1.GPA);

    // Test Course
    Console.WriteLine();
    Course CS1 = new Course("CSc127A-042002", 3.0, 4.0);  // 3-unit A
    Console.WriteLine(CS1.ToString());
    Console.WriteLine("units: {0}", CS1.Units);
    Console.WriteLine("grade: {0}", CS1.Grade);
    Course CS2 = new Course("CSc127A-012004", 4.0, 3.0); // 4-unit B
    Course PE101 = new Course("PE101-022004", 1.0, 2.0); // 1-unit C

    // Test the relationship between Student and Course
    s1.RecordCourse(CS1);
    s1.RecordCourse(CS2);
    s1.RecordCourse(PE101);

    Console.WriteLine();
    Console.WriteLine(s1);
  }
}