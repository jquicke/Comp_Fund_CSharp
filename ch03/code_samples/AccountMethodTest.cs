// Send messages to two BankAccount objects.
using System;

class AccountMethodTest
{
  static void Main()
  {
    // Construct two BankAccount objects and store them
    BankAccount anAcct = new BankAccount("Hall", 100.00); 
    BankAccount anotherAcct = new BankAccount("Fuller", 987.65);

    // Modify the state of both objects
    anAcct.Deposit(133.33);
    anotherAcct.Withdraw(250.00);

    // View the state of both objects
    Console.WriteLine("ID of anAcct: {0}", anAcct.ID);
    Console.WriteLine("Balance of anAcct: {0}", anAcct.Balance);
    Console.WriteLine("anotherAcct: {0}",
                      anotherAcct.ToString());
  }
}