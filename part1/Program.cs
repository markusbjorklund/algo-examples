using System;

namespace part1
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Hello World!");

      Numbers num = new Numbers();
      Console.WriteLine(num.Sum(4075)); // 16
      Console.WriteLine(num.Sum(3)); // 3
      Console.WriteLine(num.Sum(999999999)); // 81

    }
  }
}