using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.LinkedListImpl
{
    class Node
    {
        public object nodeValue;
        public Node link;

        public Node()
        {
            nodeValue=null;
            link=null;
        }

        public Node(object element)
        {
            nodeValue = element;
            link = null;
        }
    }
}
