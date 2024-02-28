namespace 链表2_删除链表的倒数第N个节点
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

		}

		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			List<ListNode> temp = new List<ListNode> ();

			//将单链表遍历一次进入List处理
			while (head != null) {
				temp.Add(head);
				head=head.next;
			}

			//链表长度
			int length = temp.Count;

			if (length == 1 && n == 1) return null;
			if (length==n) return temp[1];

			temp[length - n - 1].next = temp[length - n].next;
			


			return temp[0];
		}
	}
}