// Deposit 5.00 to each array element and then show all elements
using System;

class AnArrayOfAccounts
{
  static void Main()
  {
    BankAccount[] accts = new BankAccount[100];

    // Initialize the first n elements
    accts[0] = new BankAccount("Hall", 0.00);
    accts[1] = new BankAccount("Small", 100.00);
    accts[2] = new BankAccount("Ewall", 200.00);
    accts[3] = new BankAccount("Westphall", 300.00);
    int n = 4;
    // Only the first n elements of account are meaningful

    // Deposit 5.00 to all BankAccount objects
    for (int index = 0;  index < n;  index++)
    {
      accts[index].Deposit(5.00);
      Console.WriteLine(accts[index]);
    }
  }
}