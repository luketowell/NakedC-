using System;

internal sealed class CaesarCipher
{
  internal static void Main()
  {
    string plainText;
    int shift;

    Console.Clear();
    Console.WriteLine("Enter your text:");
    plainText = Console.ReadLine();

    Console.WriteLine("How many digits would you like to shift by?");
    shift = Convert.ToInt32(Console.ReadLine());

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
          Console.Write("{0}", Convert.ToChar(letter + shift));
      }
    }
    Console.WriteLine("");
  }
}
