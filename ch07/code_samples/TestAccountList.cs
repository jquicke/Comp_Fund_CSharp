using System;

class TestAccountList
{
  static void Main()
  {
    AccountList accounts = new AccountList();
    Console.WriteLine("Size = {0}", accounts.Size);
    Console.WriteLine("Elements = {0}", accounts);
    // Output:
    // Size = 0
    // Elements = []

    BankAccount a1 = new BankAccount("Kim", 100.00);
    BankAccount a2 = new BankAccount("Devon", 200.00);
    BankAccount a3 = new BankAccount("Chris", 300.00);
    BankAccount a4 = new BankAccount("Chris", 400.00);
    accounts.Add(a1);
    accounts.Add(a2);
    accounts.Add(a3);
    accounts.Add(a4);  // ID Chris exists so a4 will not be added
    Console.WriteLine("Size = {0}", accounts.Size);
    Console.WriteLine("Elements = {0}", accounts);

    // Output:
    // Size = 3
    // Elements = [Kim $100.00, Devon $200.00, Chris $300.00]

    BankAccount currentAccount = accounts.GetAccountWithID("Chris");
    Console.WriteLine("Before deposit: {0}", currentAccount);
    // Output:
    // Before deposit: Chris $300.00

    currentAccount.Deposit(999.99); 
    currentAccount = accounts.GetAccountWithID("Chris");
    Console.WriteLine("After deposit: {0}", currentAccount);
    // Output:
    // After deposit: Chris $1,299.99

    accounts.RemoveAccountWithID("Chris");
    accounts.RemoveAccountWithID("Devon");
    accounts.RemoveAccountWithID("Not Here");
    Console.WriteLine("Size = {0}", accounts.Size);
    Console.WriteLine("Elements = {0}", accounts);
    // Output:
    // Size = 1
    // Elements = [Kim $100.00]
  }
}