using System;
using System.Collections.Generic;

namespace Palindromes.Objects
{
  public class Palindrome
  {
    public string Input {get; set;}
    public char[] InputBackwards {get;set;}
    public char[] InputArr {get; set;}

    public Palindrome(string input)
    {
      this.Input = input.Replace(" ", "");
      this.Input = this.Input.ToLower();
      this.InputArr = this.Input.ToCharArray();
      this.InputBackwards = this.InputArr;
      //Array.Reverse(this.InputBackwards);

      this.InputBackwards = this.ReverseHelper();
    }
    public bool Palindromic()
    {


      Console.WriteLine(this.InputArr);
      Console.WriteLine(this.InputBackwards);

      if(string.Join("", this.InputArr) == string.Join("",this.InputBackwards))
      {
        return true;
      }
      return false;
    }
      public char[] ReverseHelper()
      {
        int j = 0;
        for(int i = (this.InputArr.Length - 1); i == 0; i--)
        {
          this.InputBackwards[j] = this.InputArr[i];
          j++;
        }
        return this.InputBackwards;
      }
  }
}
