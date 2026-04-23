namespace MyBubbleSortProj;

public class MyBubbleSort<T>
    where T : IComparable<T>

{
    public void Sort(T[] items)
    {
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < items.Length; i++)
            {
                if (Compare(items[i - 1], items[i]) >0)
                {
                    Swap(items, i - 1, i);
                    swapped = true;
                }

            }
        } while(swapped !=false);
    }

    private void Swap(T[] items, int a, int b)
    {
        T temp = items[a];
        items[a] = items[b];
        items[b] = temp;
    }

    private int Compare(T t1, T t2)
    {
        return t1.CompareTo(t2);
    }
    public void ExecuteSort(T[] items)
    {
        return;
    }
}
