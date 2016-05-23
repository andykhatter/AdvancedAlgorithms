using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.BSTimpl
{
    class Node
    {
        public Node leftNode;
        public Node rightNode;
        public int value;
        public void displayNode()
        {
            Console.WriteLine(value);
        }
    }
}
