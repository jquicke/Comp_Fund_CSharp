// Test drive the Elevator class by constructing one 
// Elevator object and sending several select(floor) 
// messages, some of which are invalid.
using System;
class TestElevator
{
  static void Main()
  {
    Elevator error1 = new Elevator("No way 1", 1, -1);
    Elevator error2 = new Elevator("No way 2", 3, 2);
    Elevator error3 = new Elevator("No way 3", 0, 9);
    Elevator liftOne = new Elevator("West", 2, 12);
    Elevator liftTwo = new Elevator("East", 1, 6);

    liftOne.Select(5);
    liftTwo.Select(3);
    liftOne.Select(5);  // 5 is current floor; open at 5 again
    liftTwo.Select(7);
    liftOne.Select(1);
    liftTwo.Select(1);
    liftOne.Select(13); // Out of range--elevator does not change
    liftOne.Select(0);  // Out of range--elevator does not change
  }
}