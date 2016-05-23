using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataStructInterfaces;

namespace AdvancedDatastructures.ArrayListImpl
{
    public class ArrayGaddamnList<T>:IArrayGaddamnList<T>

    {
        private const int BASE_ARR_LENGTH = 10;
        private T[] _internalArray = new T[BASE_ARR_LENGTH];
        private int _index = 0;

        public T this[int index] 
        {
            get
            {
                if (index < 0 || index > _internalArray.Length)
                    return default(T);

                return _internalArray[index];
            }
            private set { }
        }


        public int Add(T t)
        {
            int currIndex = _index;
            SetIndex();
            _internalArray[_index] = t;
            _index++;
            return currIndex;
        }

        public int IndexOf(T t)
        {
            for (int i = 0; i < _internalArray.Length; i++)
            {
                if (_internalArray[i].Equals(t))
                    return i;
            }

            return -1;
                
            
        }

        public T GetObjectAt(int index)
        {
            if (index < 0 || index > _internalArray.Length)
                return default(T);

            return _internalArray[index];

        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > _internalArray.Length)
            { }
            else
                _internalArray[index] = default(T);
        }

        public void SetCapacity(int capacity)
        {
            throw new NotImplementedException();

        }

        private void SetIndex()
        {
            if (_index >= _internalArray.Length)
            {
                int newLength=2*_internalArray.Length;
                T[] tempArray = new T[newLength];
                for (int i = 0; i < _internalArray.Length;i++ )
                {
                    tempArray[i] = _internalArray[i];
                }

                _internalArray = tempArray;

            }
        }


    }
}
