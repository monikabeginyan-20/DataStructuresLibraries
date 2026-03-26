using LinkedListLibrary;
using System.Collections;

namespace MyQueueProj;

public class MyQueue<T> : IEnumerable<T>
{
    MyLinkedList<T> _items = new MyLinkedList<T>();

    public void Enqueue(T item)
    {
        _items.AddLast(item);
    }

    public T Dequeue()
    {
        return _items.RemoveFirst();
    }

    public T Peek()
    {
        return _items.First();
    }

    public int Count()
    {
        return (_items.Count);
    }
    public void Clear()
    {
        _items.Clear();
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
