using System.Collections.Generic;

namespace Hackerrank.Interface
{
    public interface ILinkedList<T> : IEnumerable<T>, IEnumerator<T>
    {
        int Length { get; }

        void Add(T item);

        bool Remove(T item);

        bool Contains(T item);

        T this[int index] { get; }
    }
}