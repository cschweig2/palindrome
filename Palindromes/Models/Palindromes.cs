using System;

namespace PalindromesDetector.Models
{
  public class Palindromes
  {
    public static bool IsPalindrome(string userInput)
    {
      char[] input = userInput.ToCharArray();
      char[] reversed = input;
      Array.Reverse(reversed);
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