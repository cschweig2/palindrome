using System;

namespace PalindromesDetector.Models
{
  public class Palindromes
  {
    public static bool IsPalindrome(string userInput)
    {
      string[] input = userInput.Split("");
      string[] reversed = input;
      Array.Reverse(reversed);
      foreach(string letter in reversed)
      {
          Console.WriteLine(letter.ToString());
      }
      string joinedArray = String.Concat(reversed);
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


      // foreach(char letter in newArray)
      // {
      //     Console.WriteLine(letter.ToString());
      // }
      // Console.WriteLine(input);
// foreach(string letter in input)
// {
//     Console.WriteLine(letter.ToString());
// }