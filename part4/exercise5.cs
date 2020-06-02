using System;
using System.Text;

namespace part4
{
  public class BinarySearchTree
  {
    public Nodes root;
    public BinarySearchTree()
    {
      this.root = null;
    }

    public void Add(int x)
    {
      Nodes node = new Nodes();
      node.value = x;
      if (this.root == null)
      {
        this.root = node;
      }
      else
      {
        Nodes current = this.root;
        Nodes parent;
        while (true)
        {
          parent = current;
          if (x < current.value)
          {
            current = current.left;
            if (current == null)
            {
              parent.left = node;
              break;
            }
          }
          else
          {
            current = current.right;
            if (current == null)
            {
              parent.right = node;
              break;
            }
          }
        }
      }
    }

    public int Height()
    {
      Nodes current = this.root;
      return TreeHeight(current);
    }

    public int TreeHeight(Nodes node)
    {
      if (node == null)
      {
        return -1;
      }
      int left = TreeHeight(node.left);
      int right = TreeHeight(node.right);
      if (left > right)
      {
        return left + 1;
      }
      else return right +1;
    }
  }

  public class Nodes
  {
    public int value;
    public Nodes left;
    public Nodes right;
  }
}