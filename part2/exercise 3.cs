using System;
using System.Text;

namespace part2
{
  class Changes
  {
    public int Calculate(int[] t)
    {
      int numbers = 0;
      for (int i = 1; i <= t.Length - 1; i++)
      {
        // check if this number is the same as pervious
        if (t[i] == t[i - 1])
        {
          if (i < t.Length - 1)
          {
            t[i] = t[i - 1] + t[i + 1] + 1;
            numbers++;
          }
          else
          {
            t[i] = t[i - 1] + 1;
            numbers++;
          }
        }
      }
      return numbers;
    }
  }
}