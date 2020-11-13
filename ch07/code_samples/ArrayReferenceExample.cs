using System;

class ArrayReferenceExample
{
  static void Main()
  {
    BankAccount[] accounts = new BankAccount[3];

    // Store references to 5 new BankAccount objects
    accounts[0] = new BankAccount("a", 1.00);
    accounts[1] = new BankAccount("b", 2.00);
    accounts[2] = new BankAccount("c", 3.00);

    Console.WriteLine("b's balance {0:C}", accounts[1].Balance);

    // Have two array elements refer to the same object
    accounts[0] = accounts[1];

    // Send a message to an object referenced by accounts[0]
    accounts[0].Deposit(555.55);

    // see that the object reference by accounts[1] has changed
    Console.WriteLine("b's balance {0:C}", accounts[1].Balance);
  }
}