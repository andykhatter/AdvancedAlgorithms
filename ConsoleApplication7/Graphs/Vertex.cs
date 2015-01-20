using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedDatastructures.Graphs
{
    class Vertex
    {
        public bool wasVisited;
        public string label;

        public Vertex(string value)
        {
            wasVisited = false;
            label = value;
        }
    }
}
