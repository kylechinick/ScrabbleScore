using System;
using System.Linq;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class Word
  {
    public string ScrabbleWord { get; set; }
    public static Dictionary<char, int> myDictionary = new Dictionary<char, int>() { 
        {'a', 1},
        {'e', 1},
        {'i', 1},
        {'o', 1},
        {'u', 1},
        {'l', 1},
        {'n', 1},
        {'r', 1},
        {'s', 1},
        {'t', 1},
        {'d', 2},
        {'g', 2},
        {'b', 3},
        {'c', 3},
        {'m', 3},
        {'p', 3},
        {'f', 4},
        {'h', 4},
        {'v', 4},
        {'w', 4},
        {'y', 4},
        {'k', 5},
        {'j', 8},
        {'x', 8},
        {'z', 10},
        {'q', 10},
      };
    public static int returnScore(string userWord)
    {
        string userString = userWord.ToLower();
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
    public Word(string scrabbleWord)
    {
      ScrabbleWord = scrabbleWord;
    }
  }
}