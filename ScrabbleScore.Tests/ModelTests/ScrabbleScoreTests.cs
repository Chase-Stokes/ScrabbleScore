using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void CheckScore_AReturnsOnePoint_1()
    {
      Assert.AreEqual("1", Score.CheckScore("a"));
    }
  }
}