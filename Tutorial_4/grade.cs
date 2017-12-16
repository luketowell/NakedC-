using System;

public class GradeCalculator
{
  static public void Main()
  {
    int grade;

    Console.Clear();

    Console.WriteLine("What is the grade that you want to know");
    grade = Convert.ToInt32(Console.ReadLine());

    if (grade >= 95){
      Console.WriteLine("A");
    }
    else if (grade >= 85){
      Console.WriteLine("B");
    }
    else if (grade >= 75){
      Console.WriteLine("C");
    }
    else if (grade >= 50){
      Console.WriteLine("D");
    }
    else{
      Console.WriteLine("F");
    }
  }
}
