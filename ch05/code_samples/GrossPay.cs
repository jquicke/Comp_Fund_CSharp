using System;

class GrossPay
{
  static void Main()
  {
    double pay, hoursWorked, hourlyRate, OTPay;

    Console.Write("Enter hours worked: ");
    hoursWorked = double.Parse(Console.ReadLine());
    Console.Write("Enter hourly rate: ");
    hourlyRate = double.Parse(Console.ReadLine());

    if (hoursWorked <= 40.0)
      pay = hoursWorked * hourlyRate;  
    else
    { 
      OTPay = (hoursWorked - 40) * 1.5 * hourlyRate;
      pay = (40 * hourlyRate) + OTPay;
    }

    Console.WriteLine("Gross pay: {0}", pay);
  }
}