﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgAndStruct
{
    internal class BinaryTree<T> where T:IComparable
    {
        public BinaryTreeNode<T> RootNode { get; set; }
        public BinaryTreeNode<T> Add(BinaryTreeNode<T> node,
            BinaryTreeNode<T> currentNode = null)
        {
            if (RootNode == null)
            {
                node.ParentNode = null;
                return RootNode = node;
            }
            currentNode = currentNode ?? RootNode;
            node.ParentNode = currentNode;
            int result= node.Data.CompareTo(currentNode.Data);
            if ( result== 0)
            {
                return currentNode;
            }
            else if (result < 0)
            {
                if (currentNode.LeftNode == null) return currentNode.LeftNode = node;
                else return Add(node, currentNode.LeftNode);
            }
            else if (currentNode.RightNode == null) return currentNode.RightNode = node;
                 else return Add(node, currentNode);
            //return (result = node.Data.CompareTo(currentNode.Data)) == 0 ? currentNode : result < 0 ? currentNode.LeftNode == null ? (currentNode.LeftNode = node) : Add(node, currentNode.LeftNode) :
            //  currentNode.RightNode == null ?
            //  (currentNode.RightNode = node) : Add(node, currentNode);
        }
        public BinaryTreeNode<T> Add(T data)
        {
            return Add(new BinaryTreeNode<T>(data));
        }
        public BinaryTreeNode<T> FindNode(T data, BinaryTreeNode<T> startWithNode = null)
        {
            startWithNode = startWithNode ?? RootNode;
            int result= data.CompareTo(startWithNode.Data);
            if (result == 0) return startWithNode;
            else if (result < 0)
            {
                if (startWithNode.LeftNode == null) return null;
                else return FindNode(data, startWithNode.LeftNode);
            }
            else if (startWithNode.RightNode == null) return null;
            else return FindNode(data, startWithNode.RightNode);
        }
        public void Remove(BinaryTreeNode<T> node)
        {
            if (node == null)
            {
                return;
            }
            var currentNodeSide = node.NodeSide;
            if (node.LeftNode == null && node.RightNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = null;
                }
                else
                {
                    node.ParentNode.RightNode = null;
                }
            }
            else if (node.LeftNode == null)
            {
                if (currentNodeSide == Side.Left)
                {
                    node.ParentNode.LeftNode = node.RightNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.RightNode;
                }
                node.RightNode.ParentNode = node.ParentNode;
            }
            else if (node.RightNode==null)
            {
                if(currentNodeSide==Side.Left)
                {
                    node.ParentNode.LeftNode = node.LeftNode;
                }
                else
                {
                    node.ParentNode.RightNode = node.LeftNode;
                }
                node.LeftNode.ParentNode = node.ParentNode;
            }
            else
            {
                switch (currentNodeSide)
                {
                    case Side.Left:
                        node.ParentNode.LeftNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    case Side.Right:
                        node.ParentNode.RightNode = node.RightNode;
                        node.RightNode.ParentNode = node.ParentNode;
                        Add(node.LeftNode, node.RightNode);
                        break;
                    default:
                        var bufLeft = node.LeftNode;
                        var bufRightLeft = node.RightNode.LeftNode;
                        var bufRightRight = node.RightNode.RightNode;
                        node.Data = node.RightNode.Data;
                        node.RightNode = bufRightRight;
                        node.LeftNode = bufRightLeft;
                        Add(bufLeft, node);
                        break;
                }
            }
        }

        public void Remove(T data)
        {
            var found = FindNode(data);
            Remove(found);
        }

        private void PrintTree(BinaryTreeNode<T> startNode, string indent="",Side? side = null)
        {
            if (startNode != null)
            {
                var nodeSide=side==null?"+":side==Side.Left?"L":"R";
                Console.WriteLine($"{indent}[{nodeSide}]-{startNode.Data}");
                indent += new string(' ',3);
                PrintTree(startNode.LeftNode, indent, Side.Left);
                PrintTree(startNode.RightNode, indent, Side.Right);
            }
        }
        public void PrintTree()
        {
            PrintTree(RootNode);
        }
    }
}
