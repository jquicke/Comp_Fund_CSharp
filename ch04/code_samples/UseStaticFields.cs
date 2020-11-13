using System;

class UseStaticFields
{
  static void Main()
  {
    BankAccount lucy = new BankAccount("Lucy", 34.50);
    BankAccount mike = new BankAccount("Michael", 99.99);
    BankAccount martha = new BankAccount("Martha", 1.0);
    
    Console.WriteLine(lucy);
    Console.WriteLine(mike);
    Console.WriteLine(martha);
  }
}

// This modified version of BankAccount has a static field.
public class BankAccount 
{
  // Static fields (all BankAccount objects share them)
  private static int numInstances = 0;
  
  // Fields (each BankAccount object will get its own set)
  private double balance;
  private string id;
  private int tag;

  // Constructor initializes fields with arguments
  public BankAccount(string init_id, double init_balance)
  {
    id = init_id;
    balance = init_balance;
    
    tag = numInstances;
    numInstances = numInstances + 1;
  }
  
  // Return a textual representation of the state of this object
  public override string ToString()
  {
    return string.Format("Account {0}: {1} {2:C}",
                         tag, id, balance);
  }
} // End class BankAccount