using System.Text.RegularExpressions;
// using System.Text.RegularExpressions.MatchCollection;
using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static int CheckScore(string input)
    {
      string[] word = input.ToLower().Split("");
      int score = 0;
      Regex onePoint = new Regex("[aeioulnrst]");
      foreach(string letter in word)
      { 
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

