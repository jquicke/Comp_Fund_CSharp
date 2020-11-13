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
  
  public string GetLetterGrade(double percentage)
  {
    string result = string.Format("{0} got {1}% for a grade of ",
      name, percentage);
    
    if (percentage < 0.0 || percentage >  100.0)
      result += "Out of range";
    else if (percentage >= 90.0)
      result += "A";
    else if (percentage >= 80.0)
      result += "B";
    else if (percentage >= 70.0)
      result += "C";
    else if (percentage >= 60.0)
      result += "D";
    else
      result += "F";
    
    return result;
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

/*
BAD SOLUTION TO GetLetterGrade:

public string GetLetterGrade(double percentage)
{
  string result = string.Format("{0} got a grade of ", name);
  
  if (percentage >= 90.0 && percentage <= 100.0)
    result += "A";
  if (percentage >= 80.0 && percentage < 90.0)
    result += "B";
  if (percentage >= 70.0 && percentage < 80.0)
    result += "C";
  if (percentage >= 60.0 && percentage < 70.0)
    result += "D";
  if (percentage >=  0.0 && percentage < 60.0)
    result += "F";
  if (percentage < 0.0 || percentage >  100.0)
    result += "Out of range";
  
  return result;
}
*/