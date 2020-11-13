using System;

class CollegeStudent
{
  private string name;
  private double gpa;
  
  public CollegeStudent(string initName, double initGpa)
  {
    name = initName;
    gpa = initGpa;
  }
  
  public override string ToString()
  {
    string result = name + ": ";
    
    if (gpa < 3.0)
      result += "Try harder";
    else
    { // The false part of this if/else is another if/else
      if (gpa < 4.0)
        result += "Dean's list";
      else
        result += "President's list";
    } // End else
    
    return result;
  }
}