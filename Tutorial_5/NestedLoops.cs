using System;
using System.Threading;

internal sealed class NestedLoops
{
  internal static void Main()
  {
    for(int x =0; x <= 2; x++)
    {
      for (int y = 0; y <=2; y++)
      {
        Console.WriteLine("x is {0} & y is {1}", x, y);
      }
    }
  }
}
