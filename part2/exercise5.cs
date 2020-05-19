  class Split
  {
    public int Calculate(int[] t)
    {
      int sumSplit = 0;
      int sumLeft = 0;
      int sumRight = 0;
      int[] subLeft = new int[t.Length - 1];
      int[] subRight = new int[t.Length - 1];

      // left sums added to left sub
      for (int i = 0; i <= t.Length - 1; i++)
      {
        if (i < subLeft.Length)
        {
          sumLeft += t[i];
          subLeft[i] = sumLeft;
        }
      }

      // right sums added to right sub
      for (int i = t.Length - 1; i >= 0; i--)
      {
        sumRight += t[i];
        if (i > 0)
        {
          subRight[i - 1] = sumRight;
        }
      }

      // compare subarrays and return answer
      for (int i = 0; i <= subLeft.Length - 1; i++)
      {
        if (subLeft[i] == subRight[i])
        {
          sumSplit++;
        }
      }
      return sumSplit;
    }
  }
}