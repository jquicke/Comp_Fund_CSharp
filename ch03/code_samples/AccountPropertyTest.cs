// Accesses and sets the properties of a BankAccount object.
using System;

class AccountPropertyTest
{
  static void Main()
  {
    BankAccount ba = new BankAccount("Chris", 150.00);
    
    // PIN is null until the property is set
    Console.WriteLine("ID {0}, PIN '{1}', Balance {2}",
                        ba.ID,  ba.PIN,    ba.Balance);

    // Set the PIN property
    ba.PIN = "0123";
    Console.WriteLine("ID {0}, PIN '{1}', Balance {2}",
                        ba.ID,  ba.PIN,    ba.Balance);
  }
}