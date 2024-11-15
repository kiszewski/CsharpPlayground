

public class InorderBTreeTraversalSolution
{
    public IList<int> InorderTraversal(BinaryNode<int> root)
    {
        var output = new List<int> { };

        Walk(root, output);

        return output;
    }

    private void Walk(BinaryNode<int>? node, IList<int> output)
    {
        if (node == null) return;

        Walk(node.Left, output);
        output.Add(node.Value);
        Walk(node.Right, output);
    }
}

