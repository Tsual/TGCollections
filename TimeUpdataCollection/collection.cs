using System;
using System.Collections;
using System.Collections.Generic;

namespace TGCollections
{




    public class TimeUpdataCollection<T> : IEnumerable<T>
    {
        public enum ItemOperatingState
        {
            Add, Delete, Modify
        }

        public enum ItemState
        {
            Adding, Deleted, Pending, Available
        }

        struct item
        {
            public T obj;
            public ItemState state;
            public int index;
        }

        
        item[] _items = new item[128];
        int _length = 0;
        public int Length { get => _length;  }





        T getNextE(ref int current,out bool m)
        {
            while (++current <= _length && _items[current].state == ItemState.Available)
            {
                m = true;
                return  _items[current].obj;
            }
            m = false;
            return default(T);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public struct Enumerator : IEnumerator<T>
        {
            public T Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

    public class TimeUpdataObcollection<T>:System.Collections.ObjectModel.ObservableCollection<T>
    {





    }
}
