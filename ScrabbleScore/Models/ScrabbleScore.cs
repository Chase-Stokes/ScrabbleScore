using System.Text.RegularExpressions;
using System;

namespace ScrabbleScore
{
  public class Score
  {

    // string[] PointSquares = {"One", "Two", "Three", "Four", "Five", "Eight", "Ten"};
    // PointSquares[0]

    // string[] RegExpressionList = { "\"[aeioulnrst]\"", "\"[dg]\"", "\"[bcmp]\"", "\"[fhvwy]\"", "\"[k]\"", "\"[jx]\"", "\"[qz]\""};
    
    // int[] PointScores = {1, 2, 3, 4, 5, 8, 10};
    
    // "PointSquares = Regex.Matches(input, "
    // "RegExpressionList[0]
    //  ", RegexOptions.IgnoreCase).Count;"


    public static int CheckScore(string input)  // "[aeioulnrst]"
    {
      int[] PointValues = {1, 2, 3, 4, 5, 8, 10};
      string[] RegExpressionList = { "\"[aeioulnrst]\"", "\"[dg]\"", "\"[bcmp]\"", "\"[fhvwy]\"", "\"[k]\"", "\"[jx]\"", "\"[qz]\""};
      int rollingTotal = 0;
      int i = 0;
      foreach(string element in RegExpressionList)
      {
        rollingTotal += Regex.Matches(input, RegExpressionList[i], RegexOptions.IgnoreCase).Count * PointValues[i];
        i++;
      }
      return rollingTotal;
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



// {
//   string[] arrayOfLetters = {"[]", "[aeioulnrst]", "[worthtwopoints]", "[worththreepoints]", etc etc} //empty indexes for non-point values
// int rollingTotal = 0;
// for (int i = 1; i =< 10; i++)
// {
//   rollingTotal += Regex.Matches(input, ("\"" + arrayOfLetters[i] + "\""), RegexOption.IgnoreCase).Count * i;
// }
// return rollingTotal;
// }
