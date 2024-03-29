﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures_and_Algorithms_In_Depth_Csharp___Udemy
{
    // inorder traversal method and binary search tree implementation

    // node of the binary search tree

    /*
       Using link representation
         
    */

    // creating Node class
    public class NodeBST
    {
        public int element; // any data type possible
        public NodeBST left; // left node 
        public NodeBST right; // right node

        // constructor
        public NodeBST(int e, NodeBST l, NodeBST r)
        {
            element = e; // assign element
            left = l; // assign left node
            right = r; // assign right node
        }

    }


    class BinarySearchTree
    {

        // variables are private by default, if not specified: https://stackoverflow.com/questions/31302825/inaccessible-due-to-its-protection-level
        public NodeBST root; // declared root node

        // constructor
        public BinarySearchTree()
        {
            root = null;
        }

        // in order traversal
        public void inorder(NodeBST temproot)
        {
            // if it is not empty, then it have nodes
            if (temproot != null)
            {
                // calling recursively the method
                inorder(temproot.left);
                Console.Write(temproot.element + " ");

                // calling recursively right
                inorder(temproot.right);
            }

        }

        // preoder traversal

        public void preorder(NodeBST temproot)
        {
            if (temproot != null)
            {
                Console.Write(temproot.element + " ");
                preorder(temproot.left);
                preorder(temproot.right);
            }
        }

        // postorder traversal

        public void postorder(NodeBST temproot)
        {
            if (temproot != null)
            {
                postorder(temproot.left);
                postorder(temproot.right);
                Console.Write(temproot.element + " ");
            }
        }

        // level order traversal

        public void levelorder()// travel level by level, we need to store child of the node level by level
        {

        }

        // insert
        public void insert(NodeBST temproot, int e)
        {
            NodeBST temp = null;

            // before we insert the node, we need to search where we can place it
            while (temproot != null)
            {
                temp = temproot;

                // if the elment is already present in binary search tree, then return, as we cannot have duplicates in BST
                if (e == temproot.element)
                {
                    return;
                }

                // if the element is smaller than the element in node, if yes, move the temproot to left subtree
                else if (e < temproot.element)
                {
                    temproot = temproot.left;
                }

                // if the element is greater than the temproot, then move it to right subtree
                else if (e > temproot.element)
                {
                    temproot = temproot.right;
                }

                // once done, we found the place, where the node can be inserted
            }
                // new node need to be created
                NodeBST n = new NodeBST(e, null, null);

                // check if the root is not empty

                if(root != null)
                {  
                    // should be inserted as left subtree
                    if (e < temp.element)
                    {
                        temp.left = n;
                    }
                    else
                    {
                        temp.right = n;
                    }
                }

                // if the root is empty, then new root should be assigned
                else
                {
                    root = n;
                }
        }

        // recursive insert

        public NodeBST insertx (NodeBST temproot, int e)
        {
            // find the temp root
            if(temproot != null)
            {
                if (e < temproot.element)
                {
                    temproot.left = insertx(temproot.left, e);
                }
                else if (e > temproot.element)
                {
                    temproot.right = insertx(temproot.right, e);
                }
            }

            // once the temproot is not null, we need to create node
            else
            {
                NodeBST n = new NodeBST(e, null, null);
                temproot = n;
            }

            return temproot;
        }

        // Iterative search

        public bool searchIterative(int key) // int key - parameter we are trying to return
        {
            NodeBST temproot = root;

            // this while loop would execute and terminate, if we would find the key
            while (temproot != null)
            {
                if(key == temproot.element)
                {
                    return true;
                }
                else if(key < temproot.element)
                {
                    temproot = temproot.left;
                }
                else if(key > temproot.element) 
                {
                    temproot = temproot.right;
                }
            }
            return false; // if the element is not found, then return false
        }

        // recursive search 
        public bool searchRecursive (NodeBST temproot, int key)
        {
            if (temproot != null)
            {
                if(key == temproot.element)
                {
                    Console.WriteLine("Element found: " + key);
                    return true;
                }
                // if element not found and key is smaller than the temproot element then call recursive search again within left subtree
                else if(key < temproot.element)
                {
                    return searchRecursive(temproot.left, key);
                }

                // if element not found and key is smaller than the temproot element then call recursive search again within right subtree
                else if (key > temproot.element)
                {
                    return searchRecursive(temproot.right, key);
                }
            }
            // element not found
            return false;
        }

        // deletetion 

        public bool delete(int e)
        {
            NodeBST p = root;
            NodeBST pp = null; // parent of the parent node

            // searching for the element to be deleted 
            while(p!=null && p.element != e)
            {
                pp = p; // reference the parent node to parent of parent
                if(e < p.element)
                {
                    p = p.left;
                }
                else
                {
                    p = p.right;
                }
            }

            // element we are deleting is present or not
            if(p == null)
            {
                return false;
            }

            if(p.left != null && p.right != null)
            {
                NodeBST s = p.left;
                NodeBST ps = p;

                
                while(s.right != null)
                {
                    ps = s;
                    s = s.right;
                }
                p.element = s.element; // not deleting node, but replacing elements
                p = s;
                pp = ps;
            }

            // have left or right subtree
            NodeBST c = null;

            if(p.left != null)
            {
                c = p.left;
            }
            else
            {
                c = p.right;
            }

            // now we need to check if node we are deleting is root node
            if (p == root)
            {
                root = null;
            }

            // case one and two in deletion
            else
            {
                if(p == pp.left)
                {
                    pp.left = c;
                }
                else
                {
                    pp.right = c;
                }
            }
            return true;
        }

        // count amount of nodes in tree
        public int count(NodeBST temproot)
        {
            if (temproot != null)
            {
                int x = count(temproot.left);
                int y = count(temproot.right);
                return x + y + 1;
            }
            return 0;
        }

        // finding height of binary search tree, will return height of binary tree

        public int height(NodeBST temproot)
        {
            // recursive call, find height of left subtree and right subtree on each level, and compare which is greater

            if (temproot != null)
            {
                int x = height(temproot.left);
                int y = height(temproot.right);

                if(x > y)
                {
                    return x + 1;
                }
                else
                {
                    return y + 1;
                }
            }
            return 0;
        }
    }
}
