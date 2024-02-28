namespace 树_二叉树的最大深度
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public static int MaxDepth(TreeNode root)
		{
			if (root == null) return 0;

			int leftRootDepth = 0;
			int rightRootDepth = 0;

			if (root.left!=null)
			{
				leftRootDepth = MaxDepth(root.left);
				leftRootDepth++;
			}
			if (root.right != null)
			{
				rightRootDepth = MaxDepth(root.right);
				rightRootDepth++;
			}
			if (root.left==null&root.right==null)
			{
				return 1;
			}
			return leftRootDepth >= rightRootDepth ? leftRootDepth : rightRootDepth;
		}
	}
}