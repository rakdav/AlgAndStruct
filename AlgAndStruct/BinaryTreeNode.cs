using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgAndStruct
{
    enum Side
    {
        Left,Right
    }
    class BinaryTreeNode<T> where T:IComparable
    {
        public T Data { get; set; }
        public BinaryTreeNode(T data)
        {
            Data = data;
        }
        public BinaryTreeNode<T> LeftNode { get; set; }
        public BinaryTreeNode<T> RightNode { get; set; }
        public BinaryTreeNode<T> ParentNode { get; set; }
        public Side? NodeSide =>
            ParentNode == null ? (Side?)null : ParentNode.LeftNode == this ? Side.Left : Side.Right;

        public override string ToString() => Data.ToString();
    }
}
