using System;
using System.Collections.Generic;
using System.Text;

namespace part5
{
  public class Communication
  {
    public int n;
    public List<int>[] graph;

    public Communication(int n)
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

    public void DFSUtil(int x, bool[] visited)
    {
      visited[x - 1] = true;
      foreach (int i in graph[x])
      {
        if (!visited[i - 1])
        {
          DFSUtil(i, visited);
        }
      }
    }

    public bool Examine(int x, int y)
    {
      bool[] visited = new bool[n];
      DFSUtil(x, visited);
      return visited[y - 1];
    }
  }
}