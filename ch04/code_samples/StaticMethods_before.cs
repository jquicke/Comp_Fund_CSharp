using System;

class StaticMethods
{
  static void Main()
  {
    string name;
    double balance;
    
    Console.Write("Name? ");
    name = Console.ReadLine();
    
    Console.Write("Balance? ");
    balance = double.Parse(Console.ReadLine());
    
    BankAccount b1 = new BankAccount(name, balance);

    Console.Write("Name? ");
    name = Console.ReadLine();
    
    Console.Write("Balance? ");
    balance = double.Parse(Console.ReadLine());
    
    BankAccount b2 = new BankAccount(name, balance);
    
    Console.WriteLine("Accounts: {0} {1}", b1, b2);
  }
}