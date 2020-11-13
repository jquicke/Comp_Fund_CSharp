using System;

// Build a class to demonstrate sequential search
public class FriendList
{
  private string[] my_friends;
  private int my_size;

  // Build a list of friends with the same data each time. This is 
  // not realistic, but makes it easier to show sequential search.
  public FriendList()
  {
    // Make the array capable of storing up to 10 references 
    my_friends = new string[10];
    // All 10 elements have default object value of null.

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

  // To be arranged. It currently returns null just 
  // so this class compiles. Later on it will 
  // return null only if searchName is not found.
  public string Find(string searchName)
  {
    return null; // This will be designed in the next section 
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
      Console.WriteLine("{0} found", reference);
    else
      Console.WriteLine("{0} not found", searchName);

  } // End Main
} // End class FriendList