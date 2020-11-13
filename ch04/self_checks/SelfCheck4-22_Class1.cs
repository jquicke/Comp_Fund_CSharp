using System;
class Class1
{
  private int x;

  public void Method1()
  {
    x = 1;                       // (a)
    this.Method2();              // (b)
  }

  public void Method2()
  {
    this.x = 2;                  // (c)
    Method1();                   // (d)
    Method3();                   // (e)
  }

  public static void Method3()
  {
    x = 3;                       // (f)
    this.x = 4;                  // (g)
    Method1();                   // (h)
    Method2();                   // (i)
  }

  public static void Method4()
  {
    Method3();                   // (j)
    this.Method3();
  }
}