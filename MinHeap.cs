namespace MinHeapNameSpace;
using System.Collections;

public class MinHeap
{
    private List<int> data = new List<int>();

    private int length = 0;

    public int Length => length;

    public void Insert(int value)
    {
        length++;

        data.Add(value);

        if (length == 1)
        {
            return;
        }

        HeapifyUp(length - 1);
    }

    public int? Pool()
    {
        if (length == 0)
        {
            return null;
        }

        var output = data[0];

        var lastValue = data[length - 1];

        data[0] = lastValue;

        HeapifyDown(0);

        data.RemoveAt(length - 1);
        length--;

        return output;
    }

    private void HeapifyUp(int index)
    {
        var parentIdx = GetParentIndex(index);
        var parentValue = data[parentIdx];
        var value = data[index];

        if (parentValue > value)
        {
            Swap(parentIdx, index);
            HeapifyUp(parentIdx);
        }
    }

    private void HeapifyDown(int index)
    {
        var leftChildIndex = GetLeftChildIndex(index);
        var rightChildIndex = GetRightChildIndex(index);

        if (leftChildIndex >= length || rightChildIndex >= length) return;

        var leftValue = data[leftChildIndex];
        var rightValue = data[rightChildIndex];
        var value = data[index];

        if (leftValue < rightValue && value > leftValue)
        {
            Swap(leftChildIndex, index);
            HeapifyDown(leftChildIndex);
        }

        if (rightValue < leftValue && value > rightValue)
        {
            Swap(rightChildIndex, index);
            HeapifyDown(rightChildIndex);
        }
    }

    private int GetLeftChildIndex(int parentIndex)
    {
        return parentIndex * 2 + 1;
    }

    private int GetRightChildIndex(int parentIndex)
    {
        return parentIndex * 2 + 2;
    }

    private int GetParentIndex(int childIndex)
    {
        return (childIndex - 1) / 2;
    }

    private void Swap(int index1, int index2)
    {
        var temp = data[index1];

        data[index1] = data[index2];
        data[index2] = temp;
    }
}