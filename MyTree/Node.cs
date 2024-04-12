using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStruct
{
    internal class Node<T>
    {
        public T data;
        public Node<T> left;
        public Node<T> right;
        public int x;
        public int y;
        public bool visit;
        public int count;
        public Node(T data, Node<T> left, Node<T> right, int x, int y)
        {
            this.data = data;
            this.left = left;
            this.right = right;
            this.x = x;
            this.y = y;
        }
    }
}
