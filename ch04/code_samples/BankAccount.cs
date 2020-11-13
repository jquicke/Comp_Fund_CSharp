using System;

// This class models a minimal bank account.
public class BankAccount 
{
  // Fields
  // Each BankAccount object will have its balance, ID, and PIN
  private double balance;
  private string id;
  private string pin;

  // Constructor
  // Initializes the fields 
  public BankAccount(string init_id, double init_balance)
  {
    id = init_id;
    balance = init_balance;
    pin = null;    
  }

  // Properties
  // Allow access to an account's balance (gettable, not settable)
  public double Balance
  {
    get { return Math.Round(balance, 2); }
  }

  // Provide access to an account's ID (gettable, not settable)
  public string ID
  {
    get { return id; }
  }

  // Provide access to an account's PIN (gettable and settable)
  public string PIN
  {
    get { return pin; }   // Provides the value of the field
    set { pin = value; }  // changes the field
  }

  // Methods
  // Add amount to this account's balance
  public void Deposit(double amount)
  {
    // avoid negative deposits
    double realAmount = Math.Max(0, amount);
    balance = balance + realAmount;
  }

  // Subtract amount to this account's balance. The balance could go 
  // negative (see Chapter 5 to change this behavior)
  public void Withdraw(double amount)
  {
    balance = balance - amount; 
  }
} // End class BankAccount