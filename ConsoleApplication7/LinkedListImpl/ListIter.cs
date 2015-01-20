using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.LinkedListImpl
{
    class ListIter
    {
        private Node current;
        private Node previous;
        LinkedList theList;

          ListIter(LinkedList list)
        {
            theList = list;
            current = theList.getFirst();
            previous = null;


        }

        public void NextLink()
        {
            previous = current;
            current = current.link;
        }

        public Node getCurrent()
        {
            return current;
        }

        public void InsertBefore(object element)
        {
            Node newnode=new Node(element);
            if (previous.link == null)
                throw new InsertBeforeHeaderException("cant insert before header");

            else
            {
                newnode.link = current;
                previous.link = newnode;
                current = newnode;
            }
        }


    }

    public class InsertBeforeHeaderException:System.ApplicationException
    {
        public InsertBeforeHeaderException(string message)
        {
           // base("cant insert a node before header");
        }
    }
}
