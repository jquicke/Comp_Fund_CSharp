using System;

// Represents a student and his/her grades and student ID.
[Serializable]
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
