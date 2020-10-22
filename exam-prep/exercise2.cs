using System;
using System.Collections.Generic;

namespace examprep
{
  class ShortenArray
  {
    public int Calculate(int[] input)
    {

      List<int> helperArray = new List<int>();

      // this version needs some more work. fails on array4

      for (int i = 0; i < input.Length; i++)
      {
        if (helperArray.Count != 0 && input[i] == input[i - 1])
        {
          helperArray.RemoveAt(helperArray.Count -1);
        }
        else helperArray.Add(i);
      }
      return helperArray.Count;
    }
  }
}