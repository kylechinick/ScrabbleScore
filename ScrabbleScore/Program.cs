using System;
using System.Collections.Generic;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Hello!Welcome to the ScrabbleScore Application!");
      Greeting();
    }
    static void Greeting(){
      Console.WriteLine("Please enter a word!");
      string stringAnswer = Console.ReadLine();
      Word word = new Word(stringAnswer);
      Console.WriteLine(stringAnswer + "! Is this the word you want to use for your Scrabble turn? If not, type No.");
      string secondAnswer = Console.ReadLine();
      if (secondAnswer == "No" || secondAnswer == "no")
      {
        Greeting();
      } else
      {
        Console.WriteLine("Your Scrabble score for this word is: " + Word.returnScore(stringAnswer));
      }
    }
  }
}
