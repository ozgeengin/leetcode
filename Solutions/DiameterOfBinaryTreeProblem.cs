// https://leetcode.com/problems/diameter-of-binary-tree

namespace Solutions
{
    public class DiameterOfBinaryTreeProblem
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;

            return DiameterOfBinaryTree(root.left) + DiameterOfBinaryTree(root.right) + 1;
        }
    }
}
