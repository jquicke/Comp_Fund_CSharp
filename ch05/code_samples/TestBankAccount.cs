using System;

class TestBankAccount
{
  static void Main()
  { 
    BankAccount one = new BankAccount("One", 1.50); 
    if (one.Balance != 1.50)
      Console.WriteLine("Balance should be 1.50");

    // Try a successful deposit and withdrawal
    if (!one.Deposit(1.00))
      Console.WriteLine("Deposit should have succeeded!");

    if (one.Balance != 2.50)
      Console.WriteLine("Balance should be 2.50!");

    if (!one.Withdraw(1.00))
      Console.WriteLine("Deposit should have succeeded!");
    if (one.Balance != 1.50)
      Console.WriteLine("Balance should be 1.50!");

    // This BankAccount does not allow withdrawals when amount > Balance 
    if (one.Withdraw(567.89))
      Console.WriteLine("Withdrawal should have failed!");

    if (one.Balance != 1.50)
      Console.WriteLine("Balance should be 1.50!");

    // Withdrawals and deposit of negative amounts have no effect
    one.Withdraw(-2.34);
    one.Deposit(-2.34);
    if (one.Balance != 1.50)
      Console.WriteLine("Balance should be 1.50!");
  }
}