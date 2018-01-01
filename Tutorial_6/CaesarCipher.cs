using System;

internal sealed class CaesarCipher
{
  internal static void Main()
  {
    string plainText;

    Console.Clear();
    Console.WriteLine("Enter your text:");
    plainText = Console.ReadLine();

    foreach (char c in plainText){

      if (c == ' '){
        Console.WriteLine(" ");
      }
      else
      {
        char letter = c;

        if(letter >= 'X' && letter <= 'Z')
        {
          letter = (char)(letter-26);
        }
        else if(letter >= 'x' && letter <= 'z')
        {
          letter = (char)(letter-26);
        }
          Console.Write("{0}", Convert.ToChar(letter + 3));
      }
    }
    Console.WriteLine("");
  }
}
