using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.LinkedListImpl
{
    class LinkedList
    {
        protected Node header;

        public LinkedList()
        {
            header = new Node("header");
        }

        private Node Find(object item)
        {
            Node current = new Node();
            current = header;
            while (current.nodeValue != item)
                current = current.link;

            return current;
        }

        public void insert(object newNode, object after)
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

        public Node getFirst()
        {
            return header;
        }
        public void remove(object n)
        {
            
            Node previousNode = findPrevious(n);
            previousNode.link = previousNode.link.link;
        }

    }
}
