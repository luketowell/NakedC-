using System;

public class Maths
{
  static public void Main()
  {

    float farenheit;
    float celcius = 10.0f;
    farenheit = ((celcius * 9) / 5 ) + 32;

    Console.WriteLine("{0} celcius is equal to {1} farenheit", celcius, farenheit);
  }
}
