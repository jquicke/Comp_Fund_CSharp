using System;

public class SimpleClass2
{
  static void Main()
  {
    SimpleClass2 sc = new SimpleClass2("an Id");
    Console.WriteLine(sc.ID);
  }

  private string id;  // Default value of id is null

  public SimpleClass2(string initialID)
  {
    // Do not do this!  Declare a new id that is local to this 
    // constructor. This leaves the field's value as null.
    string id = initialID.Trim();  
  }
  
  public string ID
  {
    get
    {
      return id.ToUpper();   // The field id is null
    }
  }
}