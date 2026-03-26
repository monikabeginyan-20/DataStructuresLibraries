using LinkedListLibrary;

namespace StackLibrary;

public class MyStack<T>
{
    private MyLinkedList<T> _items = new MyLinkedList<T>();

    public int Count
    {
        get { return _items.Count; }
    }

    public void Push(T item)
    {
        _items.AddFirst(item);
    }

    public T Pop()
    {
        return _items.RemoveFirst();
    }

    public T Peek()
    {
        return _items.First();
    }
}