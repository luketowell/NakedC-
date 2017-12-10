using System;

public class nameTagGenerator
{

  static public void Main()
  {
    var name = "";
    var occ = "";
    var company = "";

    Console.Clear();
    Console.WriteLine("Hello , welcome to the label printer first I need some information.\n Please can you tell me your name?");
    name = Console.ReadLine();
    Console.WriteLine("Thanks {0}, now can you tell me your job title?", name);
    occ = Console.ReadLine();
    Console.WriteLine ("Finally, I just need the name of the company you work for?");
    company = Console.ReadLine();
    Console.WriteLine("Please see below your printed name badge.");
    Console.WriteLine("|**********************|\n|Name{0,18}|\n|{1,22}|\n|----------------------|\n|{2,22}|\n|**********************|", name, occ, company);
  }
}
