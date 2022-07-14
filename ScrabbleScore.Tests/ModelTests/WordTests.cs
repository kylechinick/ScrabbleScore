using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordTests
  {
    [TestMethod]
    public void ScrabbleScorer_TakesALetterReturnsAScore_Number()
    {
      Word testWord = new Word();
      Assert.AreEqual(1, testWord.ScrabbleScorer("a"));
    }

    [TestMethod]
    public void ScrabbleScorer_TakesAWordReturnsAScore_Number()
    {
      Word testWord = new Word();
      Assert.AreEqual(5, testWord.ScrabbleScorer("bee"));
    }

    [TestMethod]
    public void ScrabbleScorer_NotCaseSensitive_Number()
    {
      Word testWord = new Word();
      Assert.AreEqual(5, testWord.ScrabbleScorer("BEe"));
    }
  }
}