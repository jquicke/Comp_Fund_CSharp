using System;

// Build a class to demonstrate sequential search
public class FriendList
{
  private string[] my_friends;
  private int my_size;

  // Build a list of friends with the same data each time. This is 
  // not realistic, but it makes it easier to show sequential search.
  public FriendList()
  {
    // Make the array capable of storing up to 10 references 
    my_friends = new string[10];
    // All 10 elements of my_friends have default object value of null.

    // Now set the number of meaningful elements in the array.
    my_size = 5;

    // Now initialize the first my_size elements of the array.
    my_friends[0] = "DEBBIE";
    my_friends[1] = "JOEY";
    my_friends[2] = "BOBBIE";
    my_friends[3] = "SUSIE";
    my_friends[4] = "MIKEY";
    // my_friends[5] through my_friends[9] are null
  }

  // A correct find method to be added to the FriendList class
  public string Find(string searchName)
  {
    // Sequential search begins at the first array location
    int index = 0;

    // The loop will terminate as soon as the string is found.
    // However, now a check is first made to terminate the loop
    // when index == size. The loop continues as long as there
    // are more elements to look at (indexes 0..size-1) and the
    // searchName does not equal the array element being compared.
    while ((index < my_size) && (searchName != my_friends[index]))
    {
      // searchName has not yet been found in the array my_friends
      // so prepare to compare searchName to the next array element.
      index++;
    }

    // Return a reference to the string or null if not found in array
    if(index < my_size)
      return my_friends[index];
    else
      return null;
  }

  // for testing
  static void Main()
  {
    FriendList myFriendList = new FriendList();

    Console.Write("Enter name to search for [UPPERCASE]: ");
    string searchName = Console.ReadLine().Trim().ToUpper();

    // Determine if searchName is in myFriendList
    string reference = myFriendList.Find(searchName);

    // Report success or failure
    if (reference != null)
      Console.WriteLine(reference + " found");
    else
      Console.WriteLine(searchName + " not found");

  } // End Main
} // End class FriendList