using System;

// Show a silly recursive method
class Mystery
{
  public static int Mystery1(int j, int k)
  {
    if (j <= k)
      return 1;
    else
      return j + k + /* RP Mystery1 */ Mystery1(j - 1, k + 2);
  }

  static void Main()
  {
    Console.WriteLine("Mystery1(2, 4) = {0}", Mystery1(2, 4));
    Console.WriteLine("Mystery1(4, 2) = {0}", Mystery1(4, 2));
    Console.WriteLine("Mystery1(9, 0) = {0}", Mystery1(9, 0));
  }
}