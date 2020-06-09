using System;
using System.Collections.Generic;
using System.Text;

namespace part5
{
  public class Connectivity
  {
    public int n;
    public List<int>[] graph;
    public List<int> visited;

    public Connectivity(int n)
    {
      this.n = n;
      this.graph = new List<int>[n + 1];
      this.visited = new List<int>();

      for (int i = 1; i <= n; i++)
      {
        graph[i] = new List<int>();
      }
    }

    public void AddConnection(int a, int b)
    {
      this.graph[a].Add(b);
      this.graph[b].Add(a);
    }

    public int Calculate(int x)
    {
      if (visited.Contains(x))
      {
        return 0;
      }
      visited.Add(x);

      foreach (int i in graph[x])
      {
        Calculate(i);
      }
      return visited.Count - 1;
    }
  }
}