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
      // Time efficiency
      // O(n^2) is named Turtle
      // O(n) is named Rabbit
      Algotime counter = new Algotime();
      string ten = counter.CreateInput(10);
      string hundred = counter.CreateInput(100);
      string thousand = counter.CreateInput(1000);
      string tenthousand = counter.CreateInput(10000);

      DateTime start = DateTime.Now;
      counter.Turtle(ten);
      DateTime end = DateTime.Now;
      Console.WriteLine("=======================================");
      Console.WriteLine("Turtle total time: " + end.Subtract(start));
      Console.WriteLine("=======================================");

      DateTime start2 = DateTime.Now;
      counter.Rabbit(ten);
      DateTime end2 = DateTime.Now;
      Console.WriteLine("=======================================");
      Console.WriteLine("Rabbit total time: " + end2.Subtract(start2));
      Console.WriteLine("=======================================");

      // Console.WriteLine("In milliseconds: " + (end.Ticks - start.Ticks) / 10000.0);
      // Console.WriteLine("In seconds: " + (end.Ticks - start.Ticks) / 10000000.0);
      // Console.WriteLine("=======================================");
    }
  }
}