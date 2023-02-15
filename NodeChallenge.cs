class NodeChallenge
{
    public static int getLoopSize(Node startNode)
    {
        Dictionary<Node, int> nodesDict = new Dictionary<Node, int>();

        var currentNode = startNode;
        var loopIsCompleted = false;
        var index = 0;

        while (!loopIsCompleted)
        {
            nodesDict.Add(currentNode, index);

            index++;
            currentNode = currentNode.next;

            loopIsCompleted = nodesDict.Keys
                .Contains(currentNode);

            if (loopIsCompleted)
                return index - nodesDict[currentNode];
        }

        return 0;
    }
}

public class Node
{
    public Node next { get; set; } = null!;

    public Node(Node next)
    {
        this.next = next;
    }

    public Node()
    {
    }
}