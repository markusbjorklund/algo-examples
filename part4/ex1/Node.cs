using System;
using System.Collections.Generic;
using System.Text;

namespace part4
{
  class Node
  {
    public int value;
    public Node next;
    public Node previous;
    public Node(int value, Node next, Node previous)
    {
      this.value = value;
      this.next = next;
      this.previous = previous;
    }
  }
}