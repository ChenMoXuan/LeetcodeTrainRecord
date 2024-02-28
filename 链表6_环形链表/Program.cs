namespace 链表6_环形链表
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

		public bool HasCycle(ListNode head)
		{
			if (head == null) return false;
			ListNode slow = head.next;
			if (slow == null) return false;
			ListNode fast = head.next.next;
			if (fast == null) return false;

			while (fast != slow)
			{
				slow = slow.next;
				if (slow == null) return false;
				fast = fast.next;
				if (fast == null) return false;
				fast = fast.next;
				if (fast == null) return false;
			}

			return true;
		}
	}
}