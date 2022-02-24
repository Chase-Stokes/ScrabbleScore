using System.Text.RegularExpressions;
using System;

namespace ScrabbleScore
{
  public class Score
  {
    public static int CheckScore(string input)
    {
      string[] RegExpressionList = { "!", "[aieoulnrst]", "[dg]", "[bcmp]", "[fhvwy]", "[k]", "!", "!", "[jx]", "!", "[qz]"};
      int rollingTotal = 0, i = 0;
      foreach(string element in RegExpressionList)
      {
        rollingTotal += Regex.Matches(input, element, RegexOptions.IgnoreCase).Count * i; 
        i++;
      }
      return rollingTotal;
    }
  }
}