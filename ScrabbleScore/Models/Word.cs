using System;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {
    public int ScrabbleScorer(string userWord)
    {
      Dictionary<char, int> myDictionary = new Dictionary<char, int>() { 
        {'a', 1},
        {'b', 3},
        {'e', 1},
      };
        string userString = userWord;
        char[] ch = new char[userString.Length]; 
        for (int i = 0; i < userString.Length; i++) { 
            ch[i] = userString[i]; 
        } 
        int wordScore = 0;
        foreach  (char c in ch) { 
            wordScore += myDictionary[c];
        } 
        return wordScore;
    }
  }
}