using System;
using System.Collections;
using System.Collections.Generic;

namespace Hackerrank.Trees
{
    public class BinarySearchTree
    {
        private readonly Predicate<TreeNode> _hasLeft = x => x.Left != null;
        private readonly Predicate<TreeNode> _hasRight = x => x.Right != null;

        private TreeNode Root { get; set; }

        public void Add(int value)
        {
            var treeNodeItem = new TreeNodeItem(value);
            var treeNode = new TreeNode(treeNodeItem);

            Add(treeNode);
        }

        public void Remove(int value)
        {
            var treeNode = Find(value);

            Remove(treeNode);
        }

        public void Add(TreeNode node)
        {
            var currentNode = Root;
            if(currentNode == null)
            {
                Root = node;
                return;
            }

            while(_hasLeft(currentNode) || _hasRight(currentNode))
            {
                if(currentNode.CurrentNode.Value > node.CurrentNode.Value)
                {
                    if(_hasLeft(currentNode))
                    {
                        currentNode = currentNode.Left;
                        continue;
                    }
                }
                else if(currentNode.CurrentNode.Value < node.CurrentNode.Value)
                {
                    if(_hasRight(currentNode))
                    {
                        currentNode = currentNode.Right;
                        continue;
                    }
                }

                break;
            }

            if(currentNode.CurrentNode.Value < node.CurrentNode.Value)
            {
                currentNode.Right = node;
                node.Parent = currentNode;
            }
            else
            {
                currentNode.Left = node;
                node.Parent = currentNode;
            }
        }

        public void Remove(TreeNode node)
        {
            var parentNode = node.Parent;

            if(_hasLeft(node))
            {
                parentNode.Left = node.Left;
                var newNode = parentNode.Left;

                while(_hasRight(newNode))
                {
                    newNode = newNode.Right;
                }

                newNode.Right = node.Right;
            }
            else if(_hasRight(node))
            {
                parentNode.Right = node.Right;
            }
        }

        public TreeNode Find(int value)
        {
            var currentNode = Root;

            while(_hasLeft(currentNode) || _hasRight(currentNode))
            {
                if(currentNode.CurrentNode.Value == value)
                {
                    return currentNode;
                }

                if(currentNode.CurrentNode.Value < value)
                {
                    currentNode = currentNode.Right;
                }
                else if(currentNode.CurrentNode.Value > value)
                {
                    currentNode = currentNode.Left;
                }
            }

            if(currentNode.CurrentNode.Value == value)
            {
                return currentNode;
            }

            throw new Exception();
        }

        public IEnumerable<TreeNode> GetAllNodes()
        {
            var list = new List<TreeNode>();

            GetNextNode(Root, list);
            return list;
        }

        private void GetNextNode(TreeNode node, List<TreeNode> treeNodes)
        {
            if(node != null)
            {
                GetNextNode(node.Left, treeNodes);
                treeNodes.Add(node);
                GetNextNode(node.Right, treeNodes);
            }
        }
    }

    public class TreeNode
    {
        public TreeNode(TreeNodeItem treeNodeItem)
        {
            CurrentNode = treeNodeItem;
        }

        public TreeNode Parent { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public TreeNodeItem CurrentNode { get; }
    }

    public class TreeNodeItem
    {
        public TreeNodeItem(int value)
        {
            Value = value;
        }
        public int Value { get; }
    }
}