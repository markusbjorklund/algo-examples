using System;

namespace examprep
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("#####");
      Console.WriteLine("");
      Numbers num = new Numbers();
      Console.WriteLine(num.Steps(11)); // 5
      Console.WriteLine(num.Steps(15)); // 5
      Console.WriteLine(num.Steps(2)); // 2
      Console.WriteLine("");
      Console.WriteLine("#####");
    }
  }
}