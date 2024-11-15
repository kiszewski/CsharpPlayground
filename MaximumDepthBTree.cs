public class MaximumDepthBTree
{
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        var sum = new List<List<TreeNode>> { }; //I could use a Queue but already done BFS using Queue
        sum.Add(new List<TreeNode> { root });

        while (sum.Last().Count != 0)
        {
            var newNode = new List<TreeNode> { };

            sum.Last().ForEach((v) =>
            {
                if (v.left != null) newNode.Add(v.left);
                if (v.right != null) newNode.Add(v.right);
            });

            sum.Add(newNode);
        }

        return sum.Count - 1;
    }
}