using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static string CheckScore(string input)
    {
      string[] word = input.Split("");
      int score = 0;
      foreach(string letter in word)
      {
        letter.ToLower();
        if (letter == "a")
        {
          score += 1;
        }
      }
      return score.ToString();
    }
  }
}