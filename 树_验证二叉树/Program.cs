﻿namespace 树_验证二叉树
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

    public bool IsValidBST(TreeNode root) {
		return isValidBST(root, long.MinValue, long.MaxValue);
    }

	public bool isValidBST(TreeNode root, long minVal, long maxVal) {
		if (root == null)
		return true;
		//每个节点如果超过这个范围，直接返回false
		if (root.val >= maxVal || root.val <= minVal)
		return false;
		//这里再分别以左右两个子节点分别判断，
		//左子树范围的最小值是minVal，最大值是当前节点的值，也就是root的值，因为左子树的值要比当前节点小
		//右子数范围的最大值是maxVal，最小值是当前节点的值，也就是root的值，因为右子树的值要比当前节点大
		return isValidBST(root.left, minVal, root.val) && isValidBST(root.right, root.val, maxVal);
		//第二次尝试
		}
	}
}