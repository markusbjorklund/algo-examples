using System;
using System.Text;

namespace part2
{
  class LongestRepetition
  {
    public int Calculate(int[] t)
    {
      // max numbers matched
      int matchedNumbers = 1;
      // incrase when same digit is found
      int thisNumber = 1;
      for (int i = 1; i < t.Length; i++)
      {
        if (t[i] == t[i - 1])
        {
          thisNumber++;
        }
        else thisNumber = 1;
        if (thisNumber > matchedNumbers)
        {
          matchedNumbers = thisNumber;
        }
      }
      return matchedNumbers;
    }
  }
}