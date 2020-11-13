using System;

class StaticMethods
{
  static void Main()
  {
    // use helper method to make each account, and save the results
    BankAccount b1 = MakeAccount();
    BankAccount b2 = MakeAccount();
    Console.WriteLine("Accounts: {0} {1}", b1, b2);
  }
  
  // A static "helper" method to make and return one account
  public static BankAccount MakeAccount()
  {
    Console.Write("Name? ");
    string name = Console.ReadLine();
    
    Console.Write("Balance? ");
    double balance = double.Parse(Console.ReadLine());
    
    BankAccount acct = new BankAccount(name, balance);
    return acct;
  }
}