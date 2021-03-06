﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sandbox.TreeTraversal
{
    class Traversal
    {
        /*
         * All three of these are recursive - they create their own lists which are returned and added onto the list of the parent.
         */
        public static List<TreeNode> postOrder(TreeNode node)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            if (node.left != null) nodes.AddRange(postOrder(node.left)); // Add recursive call onto the end (via AddRange) of the List
            if (node.right != null) nodes.AddRange(postOrder(node.right));
            nodes.Add(node); // As is post order, add the parent node to the end.
            return nodes;
        }

        public static List<TreeNode> inOrder(TreeNode node)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            if (node.left != null) nodes.AddRange(inOrder(node.left));
            nodes.Add(node); // In order so add parent node in between.
            if (node.right != null) nodes.AddRange(inOrder(node.right));
            return nodes;
        }

        public static List<TreeNode> preOrder(TreeNode node)
        {
            List<TreeNode> nodes = new List<TreeNode>();
            nodes.Add(node); // Pre order so add parent node first.
            if (node.left != null) nodes.AddRange(preOrder(node.left));
            if (node.right != null) nodes.AddRange(preOrder(node.right));
            return nodes;
        }
    }
}
