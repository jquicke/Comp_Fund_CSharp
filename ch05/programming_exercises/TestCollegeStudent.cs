using System; 

class TestCollegeStudent
{
  static void Main()
  {
    CollegeStudent student = new CollegeStudent("Mary");

    student.RecordCourse(3, "A");
    Console.WriteLine(student);

    student.RecordCourse(3, "B");
    Console.WriteLine(student);

    student.RecordCourse(4, "C");
    Console.WriteLine(student);

    student.RecordCourse(3, "A");
    Console.WriteLine(student);

    student.RecordCourse(5, "B");
    Console.WriteLine(student);
  }
}