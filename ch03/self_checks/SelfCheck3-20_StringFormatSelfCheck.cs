using System;

class StringFormatSelfCheck
{
  static void Main()
  {
    double avagadro = 6.022 * Math.Pow(10, 23);
    int numInches = 12;
    double inchToCM = 2.54;     // 12 * 2.54 = 30.48
    
    string inchStr = string.Format("{0} inches is {1:F3} cm", 
                            numInches, numInches * inchToCM);
    
    string mole = string.Format("{0:E3} is a lot of atoms!", 
                                avagadro);
    
    Console.WriteLine(inchStr);
    Console.WriteLine(mole);
  }
}