using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace part3
{
  class Program
  {
    public static int[] Randomizer(int n)
    {
      Random random = new Random();
      int[] arr = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        // integers between 1 and 1000 are enough for us
        arr[i] = random.Next(1, 1001);
      }
      return arr;
    }
    
    static void Main(string[] args)
    {
      // Hello hello = new Hello();
      // hello.PrintHello(10);

      SmallestDifference s = new SmallestDifference();
      Console.WriteLine(s.Calculate(new int[] { 4, 1, 8, 5 })); // 1
      Console.WriteLine(s.Calculate(new int[] { 1, 10, 100 })); // 9
      Console.WriteLine(s.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 0
      Console.WriteLine(s.Calculate(Randomizer(10))); // depends on random

    }
  }
}