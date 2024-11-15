using System.Numerics;

class BinaryTree
{
    private BinaryNode<int> _root;

    public BinaryNode<int> Root { get => _root; }

    public BinaryTree(BinaryNode<int> root)
    {
        this._root = root;
    }

    public void Add(int value)
    {
        Add(new BinaryNode<int>(value), _root);
    }

    private void Add(BinaryNode<int> newValue, BinaryNode<int> root)
    {
        if (root.Value == newValue.Value) return;

        if (root.Value > newValue.Value)
        {
            if (root.Left != null)
            {
                Add(newValue, root.Left);
            }
            else
            {
                root.Left = newValue;
                return;
            }
        }
        else if (root.Value < newValue.Value)
        {
            if (root.Right != null)
            {
                Add(newValue, root.Right);
            }
            else
            {
                root.Right = newValue;
                return;
            }
        }
    }
}

public class BinaryNode<T> where T : INumber<T>
{
    public T Value { get; set; }
    public BinaryNode<T>? Left { get; set; }
    public BinaryNode<T>? Right { get; set; }

    public BinaryNode(T value, BinaryNode<T>? left = null, BinaryNode<T>? right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }

    public void Add(T newValue, BinaryNode<T>? node = null)
    {
        if (Value == newValue) return;

        if (Value > newValue)
        {
            if (Left != null)
            {
                Add(newValue, Left);
            }
            else
            {
                Left = new BinaryNode<T>(newValue);
                return;
            }
        }
        else if (Value < newValue)
        {
            if (Right != null)
            {
                Add(newValue, Right);
            }
            else
            {
                Right = new BinaryNode<T>(newValue);
                return;
            }
        }
    }
}