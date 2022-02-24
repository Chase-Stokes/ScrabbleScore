using System;
using ScrabbleScore;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      string input = "";
      Console.WriteLine("Would you like to check a word for its scrabble score? (type: '{word to check}/EXIT')");
      while (input != "EXIT")
      {
        Console.WriteLine("Enter the word you want the scrabble score for: ");
        input = Console.ReadLine();
        Console.WriteLine(Score.CheckScore(input));
      }
    }

  }
}