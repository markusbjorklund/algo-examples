using System;
using System.Text;

namespace part3
{
  class Inversions
  {
    public int[] Create(int n, int k)
    {
      int[] array = new int[n];

      for (int i = 0; i < n; i++)
      {
        array[i] = i + 1;
      }

      int inversions = 0;
      int indexA = 0;
      int indexB = 1;

      while (inversions < k)
      {
        int temp = array[indexB];
        array[indexB] = array[indexB - 1];
        array[indexB - 1] = temp;

        inversions++;
        indexB--;

        if (indexA == indexB)
        {
          indexB = (n - 1);
          indexA++;
        }
      }
      return array;
    }
  }
}