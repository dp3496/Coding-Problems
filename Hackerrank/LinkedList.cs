using System;
using System.Collections;
using Hackerrank.Interface;

namespace Hackerrank
{
    public class LinkedList<T> : ILinkedList<T>
    {
        private int _itemsCount = 0;
        private DataItem _dataItem;

        private DataItem _startItem;

        private DataItem _currentItem;
        
        public void Add(T item)
        {   
            var temp = new DataItem { CurrentItem = item };

            if(_dataItem == null)
            {
                _dataItem = temp;
                _startItem = temp;
                _currentItem = temp;
            }
            else
            {
                DataItem localItem = _dataItem;

                while (localItem.Next != null)
                {
                    localItem = localItem.Next;
                };

                localItem.Next = temp;
            }

            _itemsCount++;
        }

        public bool Remove(T item)
        {
            var temp = _dataItem;

            int removeIndex = -1;

            while ((temp != null) && !temp.CurrentItem.Equals(item))
            {
                temp = temp.Next;

                removeIndex++;
            }

            if(temp == null)
            {
                return false;
            }

            temp = temp.Next;

            var rItem = _dataItem;

            for (int i = 0; i < removeIndex; i++)
            {
                rItem = rItem.Next;    
            }

            rItem.Next = temp;

            _itemsCount--;

            return true;
        }

        public bool Contains(T item)
        {
            return false;
        }

        private T GetCurrentItem(int index)
        {
            DataItem temp = _dataItem;

            if(index > _itemsCount)
            {
                throw new IndexOutOfRangeException();
            }

            int i = 1;

            while (i <= index)
            {
                temp = temp.Next;
                i++;
            }

            return temp.CurrentItem;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            var canMoveNext = _currentItem?.Next != null;
            _currentItem = _currentItem.Next;
            return canMoveNext;
        }

        public void Reset()
        {
            return;
        }

        public void Dispose()
        {
            _dataItem = null;
        }

        public T this[int index]
        {
            get
            {
                return GetCurrentItem(index);
            }
        }

        public int Length => _itemsCount;

        public object Current
        {
            get
            {
                return _currentItem.CurrentItem;
            }
        }

        T System.Collections.Generic.IEnumerator<T>.Current => _currentItem.CurrentItem;

        private class DataItem
        {
            public T CurrentItem { get; set; }

            public DataItem Next { get; set; }
        }
    }
}