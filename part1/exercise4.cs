using System;
using System.Collections.Generic;

namespace part1
{
  public class LuckyNumbers
  {
    public int Calculate(int a, int b)
    {
      // An integer is a lucky number, if every number in it is either 3 or 7. For example, 3, 7, 33, 37, 73, 77, and 733737 are lucky numbers. Your assigment is to calculate lucky numbers between a…b.

      // HINT! Calculate from 1 to a and 1 to b separately, and subtract them.
      // HINT! Do not go through all the numbers, it is very inefficient. Try to find a mathematical pattern! 

      // Console.WriteLine(luck.Calculate(1, 10)); // 2
      // Console.WriteLine(luck.Calculate(123, 321)); // 0
      // Console.WriteLine(luck.Calculate(1, 1000000)); // 126

      // 3, 7, 33, 37, 73, 77, 333, 337, 373, 377, 733, 737, 777, 3333, 3337

      /*

      3, 33, 37, 333, 337, 373, 377, 3333, 3337

      7, 73, 77, 733, 737, 773, 777, 7333, 7337 

      */

      // int luckyNumbers = 0;
      return 0;
    }
  }
}