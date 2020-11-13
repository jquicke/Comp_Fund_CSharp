using System;

// Demonstrate a recursive method that determines if 
// any string reads the same backward as forward.
class PalindromeChecker
{
  // Return true if str is a palindrome or false if it is not
  public static bool IsPalindrome(string str)
  {
    if (str.Length <= 1)
      // Base case when this method knows to return true
      return true;
    else if (str[0] != str[str.Length - 1])
      // Base case when this method knows to return
      // false because the end characters do not match
      return false;
    else
      // The first and last characters are equal so ask
      // IsPalindrome if the shorter string (a simpler
      // version of this problem) is a palindrome.
      return IsPalindrome(str.Substring(1, str.Length - 2));
  }

  static void Main()
  {
    Console.WriteLine("{0} =? true", IsPalindrome(""));
    Console.WriteLine("{0} =? true", IsPalindrome("A"));
    Console.WriteLine("{0} =? false", IsPalindrome("no"));
    Console.WriteLine("{0} =? true", IsPalindrome("abba"));
    Console.WriteLine("{0} =? true", IsPalindrome("racecar"));
    Console.WriteLine("{0} =? false", IsPalindrome("oh-no"));
  }
}