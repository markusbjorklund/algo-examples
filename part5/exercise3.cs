using System;
using System.Collections.Generic;
using System.Text;

namespace part5
{
  public class Components
  {
    public int n;
    public List<int>[] graph;

    public Components(int n)
    {
      this.n = n;
      this.graph = new List<int>[n + 1];

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

    public void DFSUtil(int v, bool[] visited)
    {
      visited[v - 1] = true;
      foreach (int i in graph[v])
      {
        if (!visited[i - 1])
        {
          DFSUtil(i, visited);
        }
      }
    }

    public int Calculate()
    {
      int sum = 0;
      bool[] visited = new bool[n];
      for (int v = 1; v <= n; v++)
      {
        if (!visited[v - 1])
        {
          DFSUtil(v, visited);
          sum++;
        }
      }
      return sum;
    }
  }
}