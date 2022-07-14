using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {
    public int ScrabbleScorer(string letter)
    {
      Dictionary<string, int> myDictionary = new Dictionary<string, int>() { {"A", 1}};
      return myDictionary[letter];
    }
    // properties, constructors, methods, etc. go here
  }
}