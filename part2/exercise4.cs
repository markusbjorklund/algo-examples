using System;
using System.Text;

namespace part2
{
  class Revolutions
  {
    public int Calculate(int[] t)
    {
      // number of revolutions, looping as i 
      int revs = 0;
      // current number
      int curr = 1;
      for (int i = 1; i <= t.Length; i++)
      {
        for (int j = 0; j < t.Length; j++)
        {
          if (t[j] == curr)
          {
            curr++;
            if (curr == t.Length);
            {
              revs = i;
            }
          }
        }
      }
      return revs;
    }
  }
}