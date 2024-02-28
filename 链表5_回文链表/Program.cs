namespace 链表5_回文链表
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

		public static bool IsPalindrome(ListNode head)
		{
			ListNode fast = head, slow = head;
			//通过快慢指针找到中点
			
			while (fast != null && fast.next != null)
			{
				fast = fast.next.next;
				slow = slow.next;
			}

			//如果fast不为空，说明链表的长度是奇数个
			if (fast!=null)
			{
				slow = slow.next;
			}

			//反转后半部分链表
			slow = reverse(slow);

			fast = head;
			while (slow != null)
			{
				//然后比较，判断节点值是否相等
				if (fast.val != slow.val)
				{
					return false;
				}
				fast = fast.next;
				slow = slow.next;
			}

			
			return true;
		}

		//反转链表
		public static ListNode reverse(ListNode head)
		{
			ListNode prev = null;
			while (head != null)
			{
				ListNode next = head.next;
				head.next = prev;
				prev = head;
				head = next;
			}
			return prev;
		}
	}
}