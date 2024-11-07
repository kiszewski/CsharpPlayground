using MinHeapNameSpace;

public class MinHeapTests
{
    public static void Main()
    {
        var heap = new MinHeap();

        // Manual Test Assertions
        AssertEqual(heap.Length, 0, "Heap should start empty.");

        heap.Insert(5);
        heap.Insert(3);
        heap.Insert(69);
        heap.Insert(420);
        heap.Insert(4);
        heap.Insert(1);
        heap.Insert(8);
        heap.Insert(7);

        AssertEqual(heap.Length, 8, "Heap length should be 8 after 8 insertions.");
        AssertEqual(heap.Pool(), 1, "The smallest element should be 1.");
        AssertEqual(heap.Pool(), 3, "The next smallest element should be 3.");
        AssertEqual(heap.Pool(), 4, "The next smallest element should be 4.");
        AssertEqual(heap.Pool(), 5, "The next smallest element should be 5.");
        AssertEqual(heap.Length, 4, "Heap length should be 4 after 4 extractions.");

        AssertEqual(heap.Pool(), 7, "The next smallest element should be 7.");
        AssertEqual(heap.Pool(), 8, "The next smallest element should be 8.");
        AssertEqual(heap.Pool(), 69, "The next smallest element should be 69.");
        AssertEqual(heap.Pool(), 420, "The last element should be 420.");
        AssertEqual(heap.Length, 0, "Heap should be empty after removing all elements.");

        Console.WriteLine("All tests passed!");
    }

    // Helper method to assert equality and print a custom message if the test fails
    private static void AssertEqual(int? actual, int expected, string message)
    {
        if (actual != expected)
        {
            throw new Exception($"Test failed: {message} - Expected: {expected}, Actual: {actual}");
        }
    }
}
