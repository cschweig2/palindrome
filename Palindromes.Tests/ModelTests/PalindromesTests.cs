using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeDetector;

namespace PalindromeDetector.TestTools
{
  public class PalindromeTests
  {
    [TestMethod]
    public void IsPalindrome_UserInputIsString_True()
    {
      Palindromes testPalindromes = new Palindromes();
      Assert.AreEqual(true, testPalindromes.IsPalindrome("racecar"));
    }
  }
}