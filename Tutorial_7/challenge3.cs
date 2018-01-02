using System;
using System.Net;

internal sealed class CaesarCipher
{
  internal static void Main()
  {
    string plainText;
    WebClient wc = new WebClient();

    Console.Clear();
    plainText = wc.DownloadString("textfile.txt");
    Console.WriteLine(plainText);
    foreach (char c in plainText){
      if (c == ' '){
        Console.WriteLine(" ");
      }
      else
      {
        char letter = c;

        if(letter >= 'V' && letter <= 'Z')
        {
          letter = (char)(letter-26);
        }
        else if(letter >= 'v' && letter <= 'z')
        {
          letter = (char)(letter-26);
        }
          Console.Write("{0}", Convert.ToChar(letter + 5));
      }
    }
    Console.WriteLine("");
  }
}
