using LinkedListLibrary;
using StackLibrary;
using MyQueueProj;
using BinaryTreeLibrary;
using MyBubbleSortProj;

namespace GlobalTesting;

internal class Program
{
    static void Main()
    {
        TestLinkedList();
        TestStack();
        TestQueue();
        TestBinaryTree();

        Console.WriteLine("\n--- All tests completed ---");
    }

    static void TestLinkedList()
    {
        Console.WriteLine("### Testing Linked List ###");
        var list = new MyLinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);
        list.AddFirst(5);

        Console.WriteLine($"List items: {string.Join(", ", list)}"); // 5, 10, 20
        Console.WriteLine($"Count: {list.Count}");

        list.Remove(10);
        Console.WriteLine($"After removing 10: {string.Join(", ", list)}");
        Console.WriteLine();
    }

    static void TestStack()
    {
        Console.WriteLine("### Testing Stack (LIFO) ###");
        var stack = new MyStack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        Console.WriteLine($"Popped: {stack.Pop()}"); // Should be Third
        Console.WriteLine($"Popped: {stack.Pop()}"); // Should be Second
        Console.WriteLine($"Remaining count: {stack.Count}");
        Console.WriteLine();
    }

    static void TestQueue()
    {
        Console.WriteLine("### Testing Queue (FIFO) ###");
        var queue = new MyQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Should be 1
        Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Should be 2
        Console.WriteLine($"Remaining count: {queue.Count()}");
        Console.WriteLine();
    }

    static void TestBinaryTree()
    {
        Console.WriteLine("### Testing Binary Search Tree ###");
        var bst = new MyBinaryTree<int>();

        // Adding elements in unsorted order
        bst.Add(50);
        bst.Add(30);
        bst.Add(70);
        bst.Add(20);
        bst.Add(40);
        bst.Add(90);

        // In-Order Traversal should result in sorted output
        Console.WriteLine("In-Order (Sorted): " + string.Join(", ", bst));

        // Pre-Order Traversal
        Console.WriteLine("Pre-Order: " + string.Join(", ", bst.PreOrder()));

        Console.WriteLine($"Contains 40? {bst.Any(x => x == 40)}");

        bst.Remove(30);
        Console.WriteLine("After removing 30 (In-Order): " + string.Join(", ", bst));
        Console.WriteLine();
    }
}