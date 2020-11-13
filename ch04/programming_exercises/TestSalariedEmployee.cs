using System;
class TestSalariedEmployee
{ 
  static void Main()
  {
    SalariedEmployee empOne = new SalariedEmployee("Jack", 52000.00);
    SalariedEmployee empTwo = new SalariedEmployee("Jill", 53000.00);

    Console.WriteLine("{0} annual {1:C}", empTwo.Name,
                      empTwo.AnnualSalary);
    Console.WriteLine("{0} monthly {1:C}", empTwo.Name,
                      empTwo.MonthlySalary);

    Console.WriteLine("{0} annual {1:C}", empOne.Name,
                      empOne.AnnualSalary);
    Console.WriteLine("{0} monthly {1:C}", empOne.Name,
                      empOne.MonthlySalary);

    empTwo.GiveRaise(0.05);
    empOne.GiveRaise(0.10);
    Console.WriteLine(empTwo);
    Console.WriteLine(empOne);
  }
}