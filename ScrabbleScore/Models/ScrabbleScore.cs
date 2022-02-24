using System.Text.RegularExpressions;
// using System.Text.RegularExpressions.MatchCollection;
using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static int CheckScore(string input)
    {
      int OnePointSquares = Regex.Matches(input, "[aeioulnrst]", RegexOptions.IgnoreCase).Count;
      int TwoPointSquares = Regex.Matches(input, "[qg]", RegexOptions.IgnoreCase).Count * 2;
      int ThreePointSquares =  Regex.Matches(input, "[bcmp]", RegexOptions.IgnoreCase).Count * 3;
      int FourPointSquares =  Regex.Matches(input, "[fhvwy]", RegexOptions.IgnoreCase).Count * 4;
      int FivePointSquares =  Regex.Matches(input, "[k]", RegexOptions.IgnoreCase).Count * 5;
      int EightPointSquares =  Regex.Matches(input, "[jx]", RegexOptions.IgnoreCase).Count * 8;
      int TenPointSquares =  Regex.Matches(input, "[qz]", RegexOptions.IgnoreCase).Count * 10;
      int TotalPoints = OnePointSquares + TwoPointSquares + ThreePointSquares + FourPointSquares + FivePointSquares + EightPointSquares + TenPointSquares;
      return TotalPoints;
    }
  }
}

