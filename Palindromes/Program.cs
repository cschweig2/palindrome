using System;
using System.Collections.Generic;
// using Palindromes.Models;

namespace PalindromesDetector.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word below. We'll let you know if the word is a palindrome or not.");
      string userInput = Console.ReadLine();
      bool palindrome = Palindromes.IsPalindrome(userInput);
      if (palindrome)
      {
        Console.WriteLine("This is a palindrome.");
      }
      else
      {
        Console.WriteLine("This is not a palindrome.");
      }
    }
  }
}