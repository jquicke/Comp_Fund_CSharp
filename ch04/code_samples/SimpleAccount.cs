using System;

class SimpleAccount
{
  public void ObjectMethod()
  {
    Console.WriteLine("I'm in an object method!");
  }
  
  public static void StaticMethod()
  {
    // illegally try to call an object method
    ObjectMethod();
  }
}