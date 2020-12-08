using System;

namespace PalindromesDetector.Models
{
  public class Palindromes
  {
    public static bool IsPalindrome(string userInput)
    {
      string[] input = userInput.Split("");
      Array.Reverse(input);
      string joinedArray = String.Concat(input);
      if (joinedArray == userInput)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}