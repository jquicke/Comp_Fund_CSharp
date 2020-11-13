using System;

class TestPiggyBank
{
  static void Main()
  {
    // PiggyBank with 0 cents and a desired minimum of 61 cents
    PiggyBank bank = new PiggyBank(0, 61);

    // Prompt the user to get things going
    Console.WriteLine("Piggy bank has {0}", bank);
    Console.WriteLine("Add coins to reach a minimum of {0}",
      bank.Minimum);

    // loop goes until the bank does not need more cents
    while (bank.NeedsMore())
    {
      // Add a penny, nickel, dime, or quarter
      bank.AddMoreMoney(); 

      // Show updated state of the PiggyBank
      Console.WriteLine(bank);
      Console.WriteLine();
    }
  }
}