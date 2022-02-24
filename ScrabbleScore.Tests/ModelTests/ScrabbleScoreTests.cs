using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void Method_Description_ExpectedOutput()
    {
      Assert.AreEqual("output", Class.Method("input"));
    }
  }
}