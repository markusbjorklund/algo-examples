using System;
using System.Collections.Generic;
namespace part1
{
  public class LuckyNumbers
  {
    public int Calculate(int a, int b)
    {
      return CountLuckyNumbers(b) - CountLuckyNumbers(a - 1);
    }
    private int CountLuckyNumbers(int input)
    {

      List<int> numbers = new List<int>();
      if (input >= 3)
      {
        numbers.Add(3);
      }
      else return numbers.Count;
      if (input >= 7)
      {
        numbers.Add(7);
      }
      else return numbers.Count;

      // counting with variables and adding to list
      // a loop solution to remember for future use
      int i = 0;
      while (true)
      {
        int varPlusThree = numbers[i] * 10 + 3;
        int varPlusSeven = numbers[i] * 10 + 7;
        if (varPlusThree > input)
        {
          break;
        }
        numbers.Add(varPlusThree);
        if (varPlusThree > input)
        {
          break;
        }
        numbers.Add(varPlusSeven);
        i++;
      }
      return numbers.Count;
    }
  }
}