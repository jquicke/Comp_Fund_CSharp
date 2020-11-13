using System;

// This modified version of BankAccount uses a class constant.
public class BankAccount 
{
  // Class Constants: 
  // All objects share one copy; none can modify value
  public static readonly double InterestRate = 0.06;
  
  // Fields (each BankAccount object will get its own set)
  private double balance;
  private string id;

  // Constructor initializes fields with arguments
  public BankAccount(string init_id, double init_balance)
  {
    id = init_id;
    balance = init_balance;
  }
  
  // Uses shared interest rate constant to increase balance.
  public void ApplyInterest()
  {
    balance =  balance * (1.0 + InterestRate);
  }
}

class UseClassConstant
{
  static void Main()
  {
    Console.WriteLine("Interest rate is {0:P}", 
                       BankAccount.InterestRate);
  }
}