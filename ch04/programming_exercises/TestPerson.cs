using System;
class TestPerson
{
  static void Main()
  { // Test drive Person
    Person one = new Person("Kim", 19);
    Person two = new Person("Devon", 21);
    Person tre = new Person("Chris", 79);

    Console.WriteLine(one.ToString());
    Console.WriteLine(two.ToString());
    Console.WriteLine(tre.ToString());
    Console.WriteLine();
    Console.WriteLine("{0} turns 21 in {1} years",
                      one.Name, one.YearsTo(21));

    Console.WriteLine("{0} turns 40 in {1} years",
                      two.Name, two.YearsTo(40));

    Console.WriteLine("{0} turns 65 in {1} years",
                      tre.Name, tre.YearsTo(65));

    one.AgeBy(5);
    Console.WriteLine("AgeBy(5): {0}", one.ToString());
  }
}