using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicList
{
    public class DynamicList<T> : IEnumerable<T>
    {
        private T[] _dynamicList;

        public DynamicList()
        {
            _dynamicList = new T[0];
        }

        public T[] Items => _dynamicList;

        public int Count => _dynamicList.Length;

        public void Add(T item)
        {
            Array.Resize(ref _dynamicList, _dynamicList.Length + 1);
            _dynamicList[_dynamicList.Length - 1] = item;
        }

        public void Remove(T item)
        {
            _dynamicList = _dynamicList.Except(new T[] {item}).ToArray();
        }

        public void RemoveAt(int removalIndex)
        {
            if (removalIndex < 0 || removalIndex > _dynamicList.Length - 1) throw new IndexOutOfRangeException();
            for (int i = removalIndex; i < _dynamicList.Length - 1; i++)
            {
                _dynamicList[i] = _dynamicList[i + 1];
            }
            Array.Resize(ref _dynamicList, _dynamicList.Length - 1);
        }

        public void Clear()
        {
            _dynamicList = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in _dynamicList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
