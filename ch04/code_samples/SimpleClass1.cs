using System;

class SimpleClass1
{
  private string id;

  public SimpleClass1(string initialID)
  {
    id = initialID.Trim(); // Scope of initialID is the constructor
  }
  
  public string ID
  {
    get
    {
      return initialID.ToUpper();  // Should be id.ToUpper();
    }
  }
}