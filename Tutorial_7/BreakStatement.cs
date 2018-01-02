using System;
using System.Net;

internal static class BreakStatement{
    internal static void Main(){
    string word;
    string url;

    Console.WriteLine("Search Word: ");
    word = Console.ReadLine();
    Console.WriteLine("URL:");
    url = Console.ReadLine();

    WebClient wc = new WebClient();

    string webText = wc.DownloadString(url);
    string[] words = webText.Split(' ');

    foreach(string w in words)
    {
      if (w.ToUpper() == word.ToUpper())
      {
        break;
      }
    }

    Console.WriteLine("Found {0}", word);
  }

}
