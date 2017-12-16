using System;

public class Calculator
{
  static public void Main()
  {
    // Console.Clear();
    // Console.WriteLine("Please enter the radius: ");
    // var radius = Console.ReadLine();
    // float r = Convert.ToSingle(radius);
    // double c =  (2 * Math.PI) * r;
    //
    // double c2dp = Math.Round(c, 2);
    //
    // Console.WriteLine("The Circumference of your circle is: {0}", c2dp);

    string num1;
    string num2;

    Console.WriteLine("Please enter your first number: ");
    num1 = Console.ReadLine();

    Console.WriteLine("Please enter your second number: ");
    num2 = Console.ReadLine();
    float total = Convert.ToSingle(num1) + Convert.ToSingle(num2);
    Console.WriteLine("{0} + {1} = {2}", num1, num2, total);
  }

  // public int plus(var num1, var num2)
  // {
  //   return num1 + num2;
  // }
}
