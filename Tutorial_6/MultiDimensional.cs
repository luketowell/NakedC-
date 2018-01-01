using System;


internal sealed class FoodProperties{

  internal static void Main()
  {
    int [,] foodData = new int[5,6]{ /*Gms, Cal, Pr, Cb, Fb, Fat*/
      /*Cows Milk*/   {976,660,32,48,0,40},
      /*ButterMilk*/  {246,127,9 ,13,0, 5},
      /*Yogurt*/      {250,128,18,13,1, 4},
      /*Cheddar*/     {17 ,70 ,4 ,6 ,0,11},
      /*Egg*/         {100,150,12,6 ,0,12}
    };


    // Console.WriteLine("{0}", foodData[4,5]);

    for (int r=0; r<5; r++)
    {
      for (int c=0; c<6; c++)
      {
        Console.Write("{0} ", foodData [r,c]);
      }
      Console.WriteLine("");
    }
  }
}
