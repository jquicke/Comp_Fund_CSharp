using System;
using System.IO;

// Represents a student and his/her grades and student ID.
class Student
{
  private string name;
  private int id;
  private double gpa;
  
  public Student(string init_name, int init_id, double init_gpa)
  {
    name = init_name;  // initialize fields
    id = init_id;
    gpa = init_gpa;
  }
  
  public override string ToString()
  { // returns string with student's name, ID, GPA
    return string.Format("[Name={0,-16}  ID={1:D4}  GPA={2:F2}]",
                         name, id, gpa);
  }
}

// Reads student information from a file and creates
// Student objects to store it.
class ReadStudentsFromFile
{
  static void Main()
  {
    StreamReader reader = new StreamReader("students.txt");
    
    while (reader.Peek() != -1)
    {
      string line = reader.ReadLine();
      string[] tokens = line.Split(' ', '\t', ',');
      
      // now tokens array looks like this:
      // ["Jones" "" "Cindy" "5193" "3.75"]

      // build name from last name and first name
      string name = tokens[2] + " " + tokens[0];

      int id = int.Parse(tokens[3]);
      double gpa = double.Parse(tokens[4]);
      
      Student stu = new Student(name, id, gpa);
      Console.WriteLine("Student: {0}", stu);
    }
    
    reader.Close();
  }
}