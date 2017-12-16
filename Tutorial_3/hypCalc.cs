using System;

public class hypClass{

  static public void Main(){
    string a;
    string b;

    Console.Clear();
    Console.WriteLine("Please enter the length of side A: ");
    a = Console.ReadLine();
    Console.WriteLine("Please enter the length of side B: ");
    b = Console.ReadLine();

    float sideA = Convert.ToSingle(a);
    float sideB = Convert.ToSingle(b);

    double h2 = Math.Pow(sideA,2) + Math.Pow(sideB,2);
    double h = Math.Sqrt(h2);

    Console.WriteLine("The length of side c is {0}",h);
  }
}
