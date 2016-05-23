using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructInterfaces
{
    public interface IArrayGaddamnList<T>
    {
         int Add(T t);
         int IndexOf(T t);
         T GetObjectAt(int index);
         void RemoveAt(int index);
         void SetCapacity(int capacity);

    }
}
