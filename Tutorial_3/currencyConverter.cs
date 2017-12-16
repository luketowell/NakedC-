using System;

public class currencyConverter
{
  static public void Main()
  {
    string convertRate;
    string amount;

    Console.WriteLine("Enter Unit/USD rate:");
    convertRate = Console.ReadLine();
    decimal fconvert = Convert.ToDecimal(convertRate);

    Console.WriteLine("Enter Amount to Convert");
    amount = Console.ReadLine();
    decimal fAmount = Convert.ToDecimal(amount);

    decimal total = fconvert * fAmount;

    Console.WriteLine("You will receive ${0}", total);
  }
}
