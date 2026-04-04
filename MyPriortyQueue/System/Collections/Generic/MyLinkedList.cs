namespace System.Collections.Generic
{
    internal class MyLinkedList<T> where T : IComparable<T>
    {
        public int Count { get; internal set; }
        public object Head { get; internal set; }

        internal void AddBefore<T>(object current, T item) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        internal void AddLast<T>(T item) where T : IComparable<T>
        {
            throw new NotImplementedException();
        }

        internal T RemoveFirst()
        {
            throw new NotImplementedException();
        }
    }
}