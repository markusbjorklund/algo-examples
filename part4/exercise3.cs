using System;
using System.Collections.Generic;
using System.Text;

namespace part4
{
  class SmallestDistance
  {
    List<int> numList = new List<int>();
    public void Add(int x)
    {
      numList.Add(x);
    }

    public int Calculate()
    {
      numList.Sort();
      int difference = int.MaxValue;
      for (int i = 1; i != numList.Count; i++)
      {
        if (((numList[i] - numList[i - 1]) < difference))
        {
          difference = numList[i] - numList[i - 1];
        }
      }
      return difference;
    }
  }
}