using System;

class SelfCheck
{
  public static string huh(string str)
  {
    if (str[0] == '-')
      return huh(str.Substring(1, str.Length-1));
    else if (str[str.Length - 1] == '-')
      return huh(str.Substring(0, str.Length - 1));
    else
      return str;
  }

  static void Main()
  {
    Console.WriteLine(huh("+abc+"));
    Console.WriteLine(huh("-abc-"));
    Console.WriteLine(huh("-a-b-c-"));
    Console.WriteLine(huh("------abc-----"));

    Console.ReadLine();
  }
}