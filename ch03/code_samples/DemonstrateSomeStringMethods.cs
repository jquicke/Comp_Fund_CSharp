// Shows a few string constructions and methods.
using System;

class DemonstrateSomeStringMethods
{
  static void Main()
  {
    string a = "Any old";
    string b = " string";
    string astring = a + b;   // Concatenate a and b
    // astring is now "Any old string"

    // Show the string in all lowercase.
    Console.WriteLine("ToLower: {0}", astring.ToLower());

    // Show the string in all uppercase.
    Console.WriteLine("ToUpper: {0}", astring.ToUpper());

    // Show the number of characters in the string.
    Console.WriteLine("Length: {0}", astring.Length);

    // Show the position of "ring" in "Any old string".
    Console.WriteLine("IndexOf: {0}", astring.IndexOf("ring"));

    // Return the Substring, beginning at the first index 4,
    // of length 5 characters.
    Console.WriteLine("Substring 1: {0}",
                      astring.Substring(4, 5));

    // Return the Substring, beginning at the first 
    // argument (4), extending to the end of the string.  
    Console.WriteLine("Substring 2: {0}", astring.Substring(4));

    // Write the original string again, just to prove a point   
    Console.WriteLine("astring: {0}", astring);
  }
}

/*
ToLower: any old string
ToUpper: ANY OLD STRING
Length: 14
IndexOf: 10
Substring 1: old s
Substring 2: old string
astring: Any old string
*/