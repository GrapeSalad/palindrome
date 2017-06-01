using Xunit;
using System;

namespace PalindromeWork
{
  public class PalindromeTest
  {
    [Fact]
    public void IsTestPalindrome_true()
    {
      string palindrome = "a man a plan a canal panama";
      Palindrome test = new Palindrome();
      Assert.Equal(true, test.TestPalindrome(palindrome));
    }
    [Fact]
    public void IsTestPalindromeHard_true()
    {
      string palindrome = "anna";
      Palindrome test = new Palindrome();
      Assert.Equal(true, test.TestPalindromeHard(palindrome));
    }
  }
}
