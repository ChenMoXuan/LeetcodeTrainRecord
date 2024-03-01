namespace 树_验证对称二叉树
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

		public bool IsSymmetric(TreeNode root)
		{
			//想法
			//层序遍历也行
			//用深搜，调换左右顺序各来一遍，然后比较得出的数组是否相等。

			//递归
			return IsMirror(root.left, root.right);
		}

		public bool IsMirror(TreeNode node1,TreeNode node2)
		{
			if (node1 == null && node2 == null) return true;

			if (node1 == null || node2 == null||node1.val != node2.val)
			{
				return false;
			}

			//不要随便返回
			return IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
		}
	}
}