using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructInterfaces
{
    public interface IGaddamnDictionary<TKey,TValue>
    {
        void Add(TKey k, TValue v);
        IArrayGaddamnList<TKey> GetKeys();
        IArrayGaddamnList<TValue> GetValues();
        void Clear();
        bool ContainsKey(TKey k);
        bool ContainsKey(TValue v);
        IEnumerator GetEnumerator();
    }
}
