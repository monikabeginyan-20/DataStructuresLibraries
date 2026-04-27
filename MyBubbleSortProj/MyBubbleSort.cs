namespace MyBubbleSortProj;

public class MyBubbleSort<T> where T : IComparable<T>
{
    public void BubbleSort(T[] items)
    {
        if (items == null) return;
        bool swapped;

        do
        {
            swapped = false;
            for (int i = 1; i < items.Length; i++)
            {
                if (Compare(items[i - 1], items[i]) > 0)
                {
                    Swap(items, i - 1, i);
                    swapped = true;
                }
            }
        } while (swapped);
    }

    public void InsertionSort(T[] items)
    {
        if (items == null) return;

        for (int i = 1; i < items.Length; i++)
        {
            T key = items[i];
            int j = i - 1;

            while (j >= 0 && Compare(items[j], key) > 0)
            {
                items[j + 1] = items[j];
                j = j - 1;
            }
            items[j + 1] = key;
        }
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
        BubbleSort(items);
    }

}