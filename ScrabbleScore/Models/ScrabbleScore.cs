using System.Text.RegularExpressions;
// using System.Text.RegularExpressions.MatchCollection;
using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static int CheckScore(string input)
    {
      string[] word = input.Split("");
      int score = 0;
      foreach(string letter in word)
      {
        letter.ToLower();
        Regex onePoint = new Regex("aeioulnrst");
        Match onePointMatch = onePoint.Match(letter);
        if (onePointMatch.Success)
        {
          score += 1;
        }
      }
      return score;
    }
  }
}

