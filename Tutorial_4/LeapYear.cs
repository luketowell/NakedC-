using System;

public class LeapYear
{
  static public void Main()
  {

    int year;
    int test1;
    int test2;
    int test3;

    Console.Clear();
    Console.WriteLine("Please enter a year: ");
    year = Convert.ToInt32(Console.ReadLine());

    test1 = year % 4;
    test2 = year % 100;
    test3 = year % 400;

    if ((test1 == 0 && test2 != 0) || test3 == 0) {
      Console.WriteLine("This is a Leap Year")
    }
    else{
      Console.WriteLine("This is not a Leap Year")
    }
  }
}
