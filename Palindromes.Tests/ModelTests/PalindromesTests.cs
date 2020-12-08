using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromesDetector;

namespace PalindromesDetector.TestTools
{
  [TestClass]
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