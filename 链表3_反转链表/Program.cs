namespace 链表3_反转链表
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int val = 0, ListNode next = null)
		{
			this.val = val;
			this.next = next;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public static ListNode ReverseList(ListNode head,ListNode node,int n=0)
		{

			if (node.next==null) return node;
			for (int i = 0; i < n; i++)
			{
				head=node.next;
			}
			head = ReverseList(head,node.next,n++);
			return node;
		}
	}
}