namespace 链表1_删除链表中的节点
{
	public class ListNode
	{
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	}

	internal class Program
	{

		static void Main(string[] args)
		{
			int t = new Random().Next(2, 1001);
			ListNode Head = CreateLinkedList(t);

			while (Head!=null)
			{
				Console.WriteLine(Head.val);
				Head = Head.next;
			}
		}

		/// <summary>
		/// 创建一个链表
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public static ListNode CreateLinkedList(int num)
		{
			if (num <= 1) return null;

			ListNode head = null;
			ListNode sign = null;

			for (int i = 0; i < num; i++)
			{
				if (i == 0)
				{
					head = new ListNode(0);
					sign = head;
					continue;
				}

				ListNode temp = new ListNode(i);
				sign.next = temp;
				sign = temp;
			}

			return head;
		}

		public static void DeleteNode(ListNode node) 
		{
			node.val = node.next.val;
			node.next = node.next.next;
		
		}
	}


}