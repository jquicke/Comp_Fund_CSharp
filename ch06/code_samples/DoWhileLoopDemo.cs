using System;

class DoWhileLoopDemo
{
  public static readonly double AMOUNT = 10.00;
  
  static void Main()
  {
    BankAccount account = new BankAccount("Smith", 100.00);
    string choice = "";

    do
    {
      choice = GetNextOption();  // Call the method with the loop

      switch (choice)
      {
        case "W":
          account.Withdraw(AMOUNT);
          Console.WriteLine("Withdrew {0}", AMOUNT);
          break;
        case "D":
          account.Deposit(AMOUNT);
          Console.WriteLine("Deposited {0}", AMOUNT);
          break;
        case "P":
          Console.WriteLine("Account: {0}", account);
          break;
        default:
          Console.WriteLine("Have a nice day :)");
          break;
      }
    }
    while (choice != "Q");
  }

  // Prompts until user chooses an uppercase W, D, or Q
  public static string GetNextOption()
  {
    string option = "";

    // loop until one of the valid inputs is read
    do
    {
      Console.Write("W)ithdraw, D)eposit, P)rint or Q)uit: ");

      // get the first no blank character in upper case
      option = Console.ReadLine().ToUpper();

      // end loop if option is not any of the three valid choices
    }
    while (option != "W" && option != "D"
        && option != "P" && option != "Q");

    return option;
  }
}