using System;


internal sealed class ScoreProcessing{

  internal static void Main()
  {
    int[] scores;

    int numScores;

    Console.WriteLine("How many scores?");
    numScores = Convert.ToInt32(Console.ReadLine());

    scores = new int[numScores];

    for(int i=0; i<scores.Length; i++){
      Console.WriteLine("Enter score number {0}", i);
      scores[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("------- Processing -------");
    foreach(int num in scores){
      Console.WriteLine("{0}", num);
    }
  }
}
