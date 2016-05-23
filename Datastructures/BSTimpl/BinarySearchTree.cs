using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.BSTimpl
{
    class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        } 
        public void insert(int value)
        {
            Node newnode = new Node();
            newnode.value = value;
            if (root == null)
            {
                root = newnode;
            }

            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (value < parent.value)
                    {
                        current = parent.leftNode;
                        if (parent.leftNode == null)
                        {
                            parent.leftNode = newnode;
                            break;
                        }
                        
                     }

                    else 
                    {
                        current = parent.rightNode;
                        if (parent.rightNode == null)
                        {
                            parent.rightNode = newnode;
                            break;
                        }
                       
                    }

                }
            }
        }


    public  int findHeight(Node aNode)
{
    if(aNode == null)
        return -1;

    int lefth = findHeight(aNode.leftNode);
    int righth = findHeight(aNode.rightNode);

    if (lefth > righth)
        return lefth + 1;
    else
        return righth + 1;
}

    public int checkHeightBalance(Node node)
    {
        if (node == null)
            return 0;

        int lh = checkHeightBalance(node.leftNode);
        if (lh == -1)
            return -1;

        int rh = checkHeightBalance(node.rightNode);

        if (rh == -1)
            return -1;

        int diff = Math.Abs(rh - lh);
        if (diff > 1)
            return -1;

        else
            return Math.Max(rh, lh)+1;


    }

        public void inorder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                inorder(theRoot.leftNode);
                theRoot.displayNode();
                inorder(theRoot.rightNode);
            }
        }

        public void preorder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                theRoot.displayNode();
                preorder(theRoot.leftNode);
                
                preorder(theRoot.rightNode);
            }
        }

        public void postorder(Node theRoot)
        {
            if (!(theRoot == null))
            {
                postorder(theRoot.leftNode);
               
                postorder(theRoot.rightNode);

                theRoot.displayNode();
            }
        }

        public void MinVal()
        {
            Node current = root;
            while (current.leftNode != null)
            {
               

                    current = current.leftNode;
               
            }

            Console.WriteLine(current.value);
        }

        public void MaxVal()
        {
            Node current = root;
            while (current.rightNode != null)
            {


                current = current.rightNode;

            }

            Console.WriteLine(current.value);
        }

        public Node find(int key)
        {
            Node current = root;
            while (current.value != key)
            {
                if (current.value > key)
                {
                    current = current.leftNode;
                }
                else 
                {
                    current = current.rightNode;
                }
                if (current == null)
                {
                    return null;
                }
            }
            return current;
        }



        public void delete(int k)
        {
            Node current = root;
            Node parent = root;
            bool isleftNode = false;
            while (current.value != k)
            {
                parent = current;
                if (k < current.value)
                {
                    current = current.leftNode;
                    isleftNode = true;
                }
                else
                {
                    current = current.rightNode;
                    isleftNode = false;
                }
                //if (current == null)
                    //return null;

            }
           

            if (current.leftNode == null && current.rightNode == null)
            {
                if(current==root)
                root = null;

                if (isleftNode)
                    parent.leftNode = null;
                else
                    parent.rightNode = null;
            }

            else if (current.leftNode == null)
            {
                if (current == root)
                {
                    root = current.rightNode;
                }
                else if (isleftNode)
                    parent.leftNode = current.rightNode;
                else
                    parent.rightNode = current.rightNode;
            }


        }


        public Node getSuccessor(Node del)
        {
            Node successorParent=del.rightNode;
            Node successor=del.rightNode;

            while (successor.leftNode != null && successor.rightNode != null)
            {
                successorParent = successor;

                successor = successorParent.leftNode;

                if (successor == null)
                {
                    successor = successorParent;
                }


            }

            return successor;
        }

        //public void converttoLinkedList()
        //{
        //    root.displayNode();
        //    while()
        //}

        //private void convertToDoubleList()
        //{
        //    if (this.left != null)
        //        this.left.convertToDoubleList(); ;
        //    if (h == null)
        //    {
        //        h = this;
        //        t = this;
        //        this.left = null;
        //    }
        //    else
        //    {

        //        h.right = this;
        //        this.left = h;
        //        h = this;
        //    }
        //    if (this.right != null)
        //        this.right.convertToDoubleList();
        //}

        //public TreeNode toDouble()
        //{
        //    h = null;
        //    t = null;
        //    this.convertToDoubleList();
        //    return t;
        //}
    }
}

        
  

