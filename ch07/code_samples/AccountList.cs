using System;

// A class for storing a collection of BankAccount objects.
public class AccountList
{
  private BankAccount[] accountArray;  // Stores the elements
  private int size;        // Number of elements in this collection

  // Construct an empty (zero elements) collection
  public AccountList()
  {
    accountArray = new BankAccount[10];  // Initial capacity is 10
    size = 0;                       // No elements have been added
  }

  // Add a BankAccount at the end if its ID is unique to all others
  // accountToAdd: Any BankAccount you want to store in this collection.
  public bool Add(BankAccount accountToAdd)
  {
    bool result = true;

    // First check if the ID is already in the collection.
    // indexOf returns -1 if the ID is not found in accountArray
    if (IndexOf(accountToAdd.ID) != -1)
      result = false; // ID already exists, don’t allow
    else
    { // Add the account with an ID property that is
      // unique to all others. First check to ensure
      // array has the capacity to add a new element.
      if (size == accountArray.Length)
        DoubleArrayCapacity();

      // Always add accountToAdd (unless the computer
      // runs out of memory) at the "end" of the
      // meaningful elements in the array
      accountArray[size] = accountToAdd;

      // Make sure size is always increased by one
      size++;
    }

    // Return false only if the account had an ID that already existed
    return result;
  }

  // Return the index of the first occurrence of accountID as an ID.
  // Otherwise return -1 if accountID is not in this collection.
  private int IndexOf(string accountID)
  {
    int result = -1;

    // Perform a sequential search on this unordered collection
    int subscript = 0;
    while (subscript < size && result == -1)
    {
      if (accountID == accountArray[subscript].ID)
        result = subscript;
      else
        subscript++;
    }
    // Return -1 if the ID was not found in any array element
    return result;
  }

  // Change accountArray to have the same elements
  // in indexes 0..size - 1 with twice as many
  // array locations to store elements.
  private void DoubleArrayCapacity()
  {
    // Construct a new array with twice the current capacity.
    BankAccount[] temp = new BankAccount[2 * accountArray.Length];

    // Copy all existing elements into the new larger array
    for (int j = 0; j < size; j++)
      temp[j] = accountArray[j];

    // Store reference to the new larger array into this object’s field.
    accountArray = temp;
  }

  // A property to return the number of elements in this collection
  public int Size
  {
    get { return size; }
  }

  public override string ToString()
  {
    string result = "[";

    // Concatenate all but the last element as one big string
    for (int j = 0; j < Size - 1; j++)
      result += accountArray[j] + ", ";

    // Do not concatenate ", " to the last element
    if (Size > 0)
      result += accountArray[Size-1];

    result += "]";

    return result;
  }

  public BankAccount GetAccountWithID(string accountID)
  {
    BankAccount result = null;    // Assume accountID is not in the array

    int subscript = IndexOf(accountID);

    if(subscript != -1)
      result = accountArray[subscript];  // ID was found

    return result;
  }

  // Remove the first occurrence of accountToRemove if found.
  // Return true if the object was successfully removed or
  // false if accountToRemove was not found in this collection.
  public bool RemoveAccountWithID(string accountID)
  {
    bool result;
    int subscript = IndexOf(accountID);

    if (subscript == -1)
      result = false;
    else
    {
      // index is the array location of the item to be removed
      accountArray[subscript] = accountArray[size - 1];

      // No longer need two references to same object, so make it null
      accountArray[size - 1] = null;

      // Decrease the size by 1 to complete the removal of one element
      size--;

      // Let this method return true to where the message was sent
      result = true;
    }

    // Return true if element removed, false if ID was not found

    return result;
  }
}