using DataStructInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedDatastructures
{
    public  class GaddamnDictionary<TKey,TValue>
    {
        private List<TKey> _keys = new List<TKey>();
        private List<TValue> _values = new List<TValue>();
    }
}
