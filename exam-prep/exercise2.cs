using System;
using System.Collections.Generic;

namespace examprep
{
  class ShortenArray
  {
    public int Calculate(int[] input)
    {
      List<int> helperArray = new List<int>();
      for (int i = 0; i < input.Length; i++)
      {
        int number = input[i];
        if (helperArray.Count != 0 && helperArray[helperArray.Count -1] == number)
        {
          helperArray.RemoveAt(helperArray.Count -1);
        }
        else helperArray.Add(number);
      }
      return helperArray.Count;
    }
  }
}