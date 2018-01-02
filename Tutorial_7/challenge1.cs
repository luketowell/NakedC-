using System;

// in order to run this program you need to use the following command:
// mono continue.exe < capitalgeo.csv

internal static class BreakStatement
{
  internal static void Main()
  {
    string fileContents = Console.In.ReadToEnd();

    Console.Clear();

    string[] lines = fileContents.Split('\n');

    foreach (string line in lines){
      if(line.IndexOf("NULL") >= 0 || line == lines[0])
      {
        continue;
      }

      string[] fields = line.Split(',');

      float lat = Convert.ToSingle(fields[2]);
      if(lat > 0)
      {
        Console.WriteLine(line);
      }
    }
  }
}
