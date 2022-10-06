// https://leetcode.com/problems/invert-binary-tree

namespace Solutions
{
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;
            var temp = root.right;
            root.right = InvertTree(root.left);
            root.left = InvertTree(temp);

            return root;
        }
    }

    public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;

      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
          this.left = left;
          this.right = right;
      }
  }
 
}
