using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    // Test methods go here
    [TestMethod]
    public void ScrabbleScorer_TakesALetterReturnsAScore_Number()
    {
      Word testWord = new Word();
      Assert.AreEqual(1, testWord.ScrabbleScorer("A"));
    }
  }
}