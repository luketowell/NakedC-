using System;

public class challenge
{
  static public void Main()
  {
    int yearOfBirth;
    string name;
    string price;

    Console.Clear();
    Console.WriteLine("Enter Your Name:");
    name = Console.ReadLine();

    Console.WriteLine("Enter Your Birth Year");
    yearOfBirth = Convert.ToInt32(Console.ReadLine());

    if (yearOfBirth <= 1950 || yearOfBirth >= 2000 ){
      price = "$5.30";
    }
    else{
      price = "$25.00";
    }

    Console.WriteLine("|**********************|\n|   -- ADMIT ONE --   |\n|Name:{0,17}|\n|Price:{1,17}||\n|**********************|", name, price);
  }
}
