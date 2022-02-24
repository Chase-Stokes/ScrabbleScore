using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ScrabbleScore;

namespace ScrabbleScore.TestTools
{
  [TestClass]
  public class ScoreTests
  {
    // [TestMethod]
    // public void Method_Description_ExpectedOutput()
    // {
    //   Assert.AreEqual("output", Class.Method("input"));
    // }
    
    [TestMethod]
    public void CheckScore_AReturnsOnePoint_1()
    {
      Assert.AreEqual(1, Score.CheckScore("a"));
    }
    
    [TestMethod]
    public void CheckScore_EReturnsOnePoint_1()
    {
      Assert.AreEqual(1, Score.CheckScore("e"));
    }

    [TestMethod]
    public void CheckScore_IReturnsOnePoint_1()
    {
      Assert.AreEqual(1, Score.CheckScore("i"));
    }
    
    [TestMethod]
    public void CheckScore_LetReturnsThree_3()
    {
      Assert.AreEqual(3, Score.CheckScore("Let"));
    }
    
    [TestMethod]
    public void CheckScore_ZebraReturns16_16()
    {
      Assert.AreEqual(16, Score.CheckScore("Zebra"));
    }
    
    [TestMethod]
    public void CheckScore_JaxxReturns25_25()
    {
      Assert.AreEqual(25, Score.CheckScore("Jaxx"));
    }

  }
}


// A, E, I, O, U, L, N, R, S, T          1
// D, G                                  2
// B, C, M, P                            3
// F, H, V, W, Y                         4
// K                                     5
// J, X                                  8
// Q, Z                                 10