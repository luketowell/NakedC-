using System;

public class SimpleCalculator
{
  static public void Main()
  {
    float num1;
    float num2;
    string op = "";

    Console.Clear();

    Console.WriteLine("Enter Number 1:");
    num1 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter Number 2:");
    num2 = Convert.ToSingle(Console.ReadLine());

    Console.WriteLine("Enter Operator:");
    op = Console.ReadLine();

    switch(op)
    {
      case "+" :
        Console.WriteLine(num1 + num2);
        break;
      case "-" :
        Console.WriteLine(num1 + num2);
        break;
      case "*" :
        Console.WriteLine(num1*num2);
        break;
      case "/":
        Console.WriteLine(num1/num2);
        break;
      default:
          Console.WriteLine("Unable to perform calculation.");
          break;
    }
  }
}
