using System;
class TwoAccounts
{
  static void Main()
  {
    BankAccount b1 = new BankAccount("One", 100.11);
    BankAccount b2 = new BankAccount("Two", 200.22);

    b1.Deposit(50.00);
    b2.Deposit(30.00);
    b1.Withdraw(20.00);

    Console.WriteLine(b1.Balance);
    Console.WriteLine(b2.Balance);
  }
}