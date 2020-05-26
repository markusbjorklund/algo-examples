using System;
using System.Text;

namespace part3
{
  class Hello
  {
    public void PrintHello(int n)
    {
      if (n == 0) 
      {
        return;
      }
      else
      {
        Console.WriteLine("Hello!");
        PrintHello(n - 1);
      }
    }
  }
}