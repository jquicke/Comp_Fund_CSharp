using System;
public class SillyClass
{
  private double my_leftOperand;
  private double my_rightOperand;

  public SillyClass(double leftOperand, double rightOperand)
  { // Construct an object with two arguments
    my_leftOperand = leftOperand;
    my_rightOperand = rightOperand;
  }

  public double Sum
  {
    get
    {
      return my_leftOperand + my_rightOperand;
    }
  }

  public double Product
  {
    get
    {
      return my_leftOperand * my_rightOperand;
    }
  }

  public double Quotient
  {
    get
    {
      return my_leftOperand / my_rightOperand;
    }
  }
}