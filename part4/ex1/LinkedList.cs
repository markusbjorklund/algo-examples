using System;
using System.Collections.Generic;
using System.Text;

namespace part4
{
  class LinkedList
  {
    private Node head;
    private Node tail;
    public LinkedList()
    {
      this.head = null;
      this.tail = null;
    }

    public void AddFirst(int n)
    {
      Node node = new Node(n, null, null);
      if (this.head == null)
      {
        this.head = node;
        this.tail = this.head;
      }
      else
      {
        this.head.previous = node;
        node.next = this.head;
        this.head = node;
      }
    }

    public void AddLast(int n)
    {
      Node node = new Node(n, null, this.tail);
      {
        if (this.tail == null)
        {
          this.tail = node;
          this.head = this.tail;
        }
        else
        {
          this.tail.next = node;
          node.previous = this.tail;
          this.tail = node;
        }
      }
    }

    public void RemoveFirst() 
    { 
      this.head = this.head.next;
      this.head.previous = null;
    }

    public void RemoveLast() 
    { 
      this.tail = this.tail.previous;
      this.tail.next = null;
    }

    public int GetNode(int x) 
    { 
      Node current = this.head;
      for (int i = 0; i < x; i++)
      {
        current = current.next;
      }
      return current.value;
    }

    public override string ToString() 
    { 
      Node current = this.head;
      string sum = "";
      while (current != null)
      {
        sum += current.value + " ";
        current = current.next;
      }
      return sum;
    }
  }
}