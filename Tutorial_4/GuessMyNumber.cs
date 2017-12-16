using System;

public class GuessMyNumber{

  static public void Main()
  {
    string name = "Luke";
    string guess;

    Console.Clear();
    Console.WriteLine("Enter the number that you would like to guess:");
    guess = Console.ReadLine();

    if (guess == name)
    {
      Console.WriteLine("Yep");
    }
    else
    {
      Console.WriteLine("Wrong");
    }
  }
}
