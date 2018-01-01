using System;
using System.Threading;

internal sealed class guessingGame
{
  internal static void Main()
  {
    Random rand = new Random();
    // int number = rand.Next(1,101);
    int number = rand.Next(1,101);
    int guess;


    Console.Clear();
    Console.WriteLine("Guess a number: ");
    guess = Convert.ToInt32(Console.ReadLine());
    while(guess != number)
    {
      Console.WriteLine("Thats Wrong!");
      if (guess > number){
        Console.WriteLine("Your guess was too high!");
      }
      else{
        Console.WriteLine("Your guess was too low!");
      }
      Console.WriteLine("Guess again: ");
      guess = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Congrats your right");
  }
}
