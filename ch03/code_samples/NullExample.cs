// Attempts to send a message to a null reference variable.
using System;

class NullExample
{
  static void Main()
  {
    BankAccount acct = null;
    
    // the next line causes a null reference exception
    double bal = acct.Balance;
    
    Console.WriteLine(bal);
  }
}