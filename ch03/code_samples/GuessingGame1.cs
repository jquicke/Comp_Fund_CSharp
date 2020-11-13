// A guessing game written using the Random type.
using System; 

class GuessingGame1
{
  static void Main()
  { 
    // generate a random value between 1 and 100 (inclusive)
    int maximumValue = 100;
    Random randGen = new Random();
    int randomNumber = randGen.Next(1, maximumValue + 1);

    // prompt the user to guess the random number
    Console.Write("Enter a number between 1 and {0}: ", 
                  maximumValue);
    int guess = int.Parse(Console.ReadLine());
    Console.WriteLine("You guessed {0} and the right answer was {1}",
                      guess, randomNumber);
  }
}