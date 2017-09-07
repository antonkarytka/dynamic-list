using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DynamicList
{
    public class DynamicList<T> : IEnumerable<T>
    {
        public T[] dynamicList;

        public DynamicList()
        {
            dynamicList = new T[0];
        }

        public T[] Items
        {
            get { return dynamicList; }
        }

        public int Count
        {
            get { return dynamicList.Length; }
        }

        public void Add(T item)
        {
            Array.Resize(ref dynamicList, dynamicList.Length + 1);
            dynamicList[dynamicList.Length - 1] = item;
        }

        public void Remove(T item)
        {
            dynamicList = dynamicList.Except(new T[] {item}).ToArray();
        }

        public void RemoveAt(int removalIndex)
        {
            if ((removalIndex < 0) || (removalIndex > dynamicList.Length - 1)) return;
            for (int i = removalIndex; i < dynamicList.Length - 1; i++)
                dynamicList[i] = dynamicList[i + 1];

            Array.Resize(ref dynamicList, dynamicList.Length - 1);
        }

        public void Clear()
        {
            dynamicList = new T[0];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in dynamicList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
