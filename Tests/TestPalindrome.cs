using Xunit;
using System;
using System.Collections.Generic;
using Palindromes.Objects;

namespace  Palindromes
{
  public class PalindromeTester
  {
    [Fact]
    public void Palindrome_OneLetterWord_true()
    {
      //Arrange
      Palindrome newPalindrome = new Palindrome("a");
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.Palindromic());
    }
    [Fact]
    public void Palindrome_MultiLetterWord_true()
    {
      //Arrange
      Palindrome newPalindrome = new Palindrome("racecar");
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.Palindromic());
    }
    [Fact]
    public void Palindrome_Sentence_true()
    {
      //Arrange
      Palindrome newPalindrome = new Palindrome("sit on a potato pan otis");
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.Palindromic());
    }
    [Fact]
    public void Palindrome_SentenceCaseInsensitive_true()
    {
      //Arrange
      Palindrome newPalindrome = new Palindrome("Sit on a potato pan Otis");
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.Palindromic());
    }

  }
}
