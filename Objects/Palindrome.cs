using System;
using System.Collections.Generic;

namespace PalindromeWork
{
  public class Palindrome
  {
    public bool TestPalindrome(string userInput)
    {
      char [] standardArray = userInput.ToCharArray();
      Console.WriteLine(standardArray);
      Array.Reverse(standardArray);
      Console.WriteLine(standardArray);
      char [] input = userInput.ToCharArray();

      if (input.ToString() == standardArray.ToString())
      {
        return true;
      }
      else{
        return false;
      }
    }
    public bool TestPalindromeHard(string userInput)
    {
      char [] userArray = userInput.ToCharArray();
      Console.WriteLine(userArray);

      char [] reversedUserArray;
      for (var i = userArray.Length; i > 0; i --)
      {
       reversedUserArray[] = userArray[i];
      }
      Console.WriteLine(reversedUserArray);

      if (reversedUserArray.ToString() == userArray.ToString())
      {
        return true;
      }
      else{
        return false;
      }
    }

  }
}
