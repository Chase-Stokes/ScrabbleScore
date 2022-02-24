using System.Text.RegularExpressions;
using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static int CheckScore(string input)
    {

      //Refactored Previous Code to use a loop

      // int[] PointValues = {1, 2, 3, 4, 5, 8, 10};
      string[] RegExpressionList = { "!", "[aeioulnrst]", "[dg]", "[bcmp]", "[fhvwy]", "[k]", "!", "!", "[jx]", "!", "[qz]"};
      int rollingTotal = 0;
      int i = 0;
      foreach(string element in RegExpressionList)
      {
        // you can change {* i} with PointValues[i] and remove "!" from RegExpressionList to get the same result
        rollingTotal += Regex.Matches(input, element, RegexOptions.IgnoreCase).Count * i; 
        i++;
      }
      return rollingTotal;

    // Previous Code

      // int OnePointSquares = Regex.Matches(input, "[aeioulnrst]", RegexOptions.IgnoreCase).Count * 1;
      // int TwoPointSquares = Regex.Matches(input, "[dg]", RegexOptions.IgnoreCase).Count * 2;
      // int ThreePointSquares =  Regex.Matches(input, "[bcmp]", RegexOptions.IgnoreCase).Count * 3;
      // int FourPointSquares =  Regex.Matches(input, "[fhvwy]", RegexOptions.IgnoreCase).Count * 4;
      // int FivePointSquares =  Regex.Matches(input, "[k]", RegexOptions.IgnoreCase).Count * 5;
      // int EightPointSquares =  Regex.Matches(input, "[jx]", RegexOptions.IgnoreCase).Count * 8;
      // int TenPointSquares =  Regex.Matches(input, "[qz]", RegexOptions.IgnoreCase).Count * 10;
      // int TotalPoints = OnePointSquares + TwoPointSquares + ThreePointSquares + FourPointSquares + FivePointSquares + EightPointSquares + TenPointSquares;
      // return TotalPoints;
    }
  }
}