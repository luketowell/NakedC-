using System;

public class StringExplorer
{
  static public void Main()
  {
    var name = "";
    var age = "";
    Console.Clear();
    Console.WriteLine("Hello what is your name?");
    name = Console.ReadLine();
    Console.WriteLine("Hello {0}, how old are you?", name);
    age = Console.ReadLine();

    Console.WriteLine("Hello {0}, nice to know you are {1}.", name, age);
  }
}
