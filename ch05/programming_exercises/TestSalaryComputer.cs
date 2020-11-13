using System;

class TestSalaryComputer
{
  static void Main()
  { 
     // You must supply the base salary (1500.00 here) as an argument. 
    SalaryComputer s = new SalaryComputer(1500.00);
    Console.WriteLine("{0} salary is ${1}", s.Sales, s.Salary);

    s.Sales = 10001.00;
    Console.WriteLine("{0} salary is ${1}", s.Sales, s.Salary);

    s.Sales = 20002.00;
    Console.WriteLine("{0} salary is ${1}", s.Sales, s.Salary);

    // Complete this method to test all of the code
  }
}