using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace part2
{
  class Program
  {
    static void Main(string[] args)
    {
      // Revolutions
      Revolutions r = new Revolutions();
      Console.WriteLine(r.Calculate(new int[] { 4, 1, 3, 2, 5 })); // 3
      Console.WriteLine(r.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
      Console.WriteLine(r.Calculate(new int[] { 5, 4, 3, 2, 1 })); // 5

      // Changes
      // Changes m = new Changes();
      // Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 2 })); // 2
      // Console.WriteLine(m.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 0
      // Console.WriteLine(m.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 2
      // Console.WriteLine(m.Calculate(new int[] { 1, 1, 2, 2, 3, 3, 3 })); // 2

      // Repetition
      // LongestRepetition p = new LongestRepetition();
      // Console.WriteLine(p.Calculate(new int[] { 1, 2, 1, 1, 2 })); // 2
      // Console.WriteLine(p.Calculate(new int[] { 1, 2, 3, 4, 5 })); // 1
      // Console.WriteLine(p.Calculate(new int[] { 1, 1, 1, 1, 1 })); // 5
      // Console.WriteLine(p.Calculate(new int[] { 2, 2, 2, 1, 1 })); // 5

      // // Time efficiency
      // // O(n^2) is named Turtle
      // // O(n) is named Rabbit
      // Algotime counter = new Algotime();
      // string ten = counter.CreateInput(10);
      // string hundred = counter.CreateInput(100);
      // string thousand = counter.CreateInput(1000);
      // string tenthousand = counter.CreateInput(10000);

      // DateTime start = DateTime.Now;
      // counter.Turtle(ten);
      // DateTime end = DateTime.Now;
      // Console.WriteLine("=======================================");
      // Console.WriteLine("Turtle total time: " + end.Subtract(start));
      // Console.WriteLine("=======================================");

      // DateTime start2 = DateTime.Now;
      // counter.Rabbit(ten);
      // DateTime end2 = DateTime.Now;
      // Console.WriteLine("=======================================");
      // Console.WriteLine("Rabbit total time: " + end2.Subtract(start2));
      // Console.WriteLine("=======================================");
      //       DateTime start = DateTime.Now;
      //       counter.Turtle(tenthousand);
      //       DateTime end = DateTime.Now;
      //       Console.WriteLine("=======================================");
      //       Console.WriteLine("Turtle total time: " + end.Subtract(start));
      //       Console.WriteLine("=======================================");

      //       DateTime start2 = DateTime.Now;
      //       counter.Rabbit(tenthousand);
      //       DateTime end2 = DateTime.Now;
      //       Console.WriteLine("=======================================");
      //       Console.WriteLine("Rabbit total time: " + end2.Subtract(start2));
      //       Console.WriteLine("=======================================");

      // Console.WriteLine("In milliseconds: " + (end.Ticks - start.Ticks) / 10000.0);
      // Console.WriteLine("In seconds: " + (end.Ticks - start.Ticks) / 10000000.0);
      // Console.WriteLine("=======================================");
    }
  }
}