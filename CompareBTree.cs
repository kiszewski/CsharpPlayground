public class CompareBTree
{
    public bool AreEquals<T>(BinaryNode<T>? treeA, BinaryNode<T>? treeB)
    {
        if (treeA == null && treeB == null) return true;
        if (treeA == null || treeB == null) return false;

        var areEquals = treeA.Value.Equals(treeB.Value);

        if (areEquals)
        {
            var LeftAreEquals = AreEquals(treeA.Left, treeB.Left);
            var RightAreEquals = AreEquals(treeA.Right, treeB.Right);

            areEquals = LeftAreEquals && RightAreEquals;
        }

        return areEquals;
    }

    public static BinaryNode<int> Tree = new BinaryNode<int>(20,
        new BinaryNode<int>(10,
            new BinaryNode<int>(5, null, new BinaryNode<int>(7)),
            new BinaryNode<int>(15)),
    new BinaryNode<int>(50,
        new BinaryNode<int>(30,
            new BinaryNode<int>(29),
            new BinaryNode<int>(45)),
        new BinaryNode<int>(100))
);

    public static BinaryNode<int> Tree2 = new BinaryNode<int>(20,
        new BinaryNode<int>(10,
            new BinaryNode<int>(5, null, new BinaryNode<int>(7)),
            new BinaryNode<int>(15)),
        new BinaryNode<int>(50,
            null,
            new BinaryNode<int>(30,
                new BinaryNode<int>(29, null, new BinaryNode<int>(21)),
                new BinaryNode<int>(45, null, new BinaryNode<int>(49))))
    );
    public static BinaryNode<int> Tree3 = new BinaryNode<int>(20,
        new BinaryNode<int>(10,
            new BinaryNode<int>(5, null, new BinaryNode<int>(7)),
            new BinaryNode<int>(15)),
        new BinaryNode<int>(50,
            null,
            new BinaryNode<int>(30,
                new BinaryNode<int>(29, null, new BinaryNode<int>(21)),
                new BinaryNode<int>(42, null, new BinaryNode<int>(49))))
    );
}

public class BinaryNode<T>
{
    public T Value { get; set; }
    public BinaryNode<T>? Left { get; set; }
    public BinaryNode<T>? Right { get; set; }

    public BinaryNode(T value, BinaryNode<T> left = null, BinaryNode<T> right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}