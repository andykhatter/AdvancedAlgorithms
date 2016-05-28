using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.LinkedListImpl
{
    public class LinkedList
    {
        private Node header;
       
        private Node current;

        private Node Find(object item)
        {
            current = header;
            while (current.nodeValue != item)
                current = current.link;

            return current;
        }


        public void DeleteDuplicates()
        {
            Node toBeCompared = header;
            
            while (toBeCompared.link != null)
            {
                Node currentNode = header;
                Node previousNode = null;
               
                while (currentNode.link != null)
                {

                    if (!currentNode.Equals(toBeCompared) && currentNode.nodeValue == toBeCompared.nodeValue)
                    {
                        previousNode.link = currentNode.link;
                        currentNode = currentNode.link;
                    }
                    else
                    {
                        previousNode = currentNode;
                        currentNode = currentNode.link;
                        
                    }  
                }

                toBeCompared = toBeCompared.link;

            }
        }

        public void PrintLinkedList()
        {
            Node node=header;
           
            while (node.link != null)
            {
                Console.WriteLine(node.nodeValue.ToString());
                node = node.link;
            }
            if (node != null)
                Console.WriteLine(node.nodeValue.ToString());
        }

        public void Insert(object newNode)
        {
            if(header==null)
            {
               current=header=new Node(newNode);
               return;
            }

            Node newNodeObj = new Node(newNode);
            while(current.link!=null)
                current=current.link;

            current.link=newNodeObj;
            current=newNodeObj;

            return;

            
        }

        public object GetCurrentValue()
        {
            return current.nodeValue;
        }
        public void InsertAfter(object newNode, object after)
        {
            Node newNodeObj = new Node(newNode);
            Node current = new Node();
            current = Find(after);
            newNodeObj.link = current;
            current.link = newNodeObj;

        }

        private Node findPrevious(object n)
        {
            Node previousNode = new Node();
            previousNode = header;
            while (previousNode.link != null && previousNode.nodeValue != n)
                return previousNode;// = previousNode.link;

            return previousNode;
        }

        public object GetFirstElement()
        {
            return header.nodeValue;
        }
        public void remove(object n)
        {
            
            Node previousNode = findPrevious(n);
            previousNode.link = previousNode.link.link;
        }

    }
}
