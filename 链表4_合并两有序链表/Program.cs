namespace 链表4_合并两有序链表
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

		public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
		{
			//有空
			if (list1 == null || list2 == null) return list2==null?list1:list2;			
			
			ListNode curr = new ListNode();
			ListNode ret = curr;
			//无空
			while (list1!=null&&list2!=null)
			{
				if (list1.val <= list2.val)
				{
					//当前链表的下一位是
					curr.next = list1;
					//链表往下走一位
					list1 = list1.next;
				}
				else
				{
					//当前链表的下一位是
					curr.next = list2;
					//链表往下走一位
					list2 = list2.next;
				}
				curr = curr.next;
			}

			//有空
			curr.next = list1 == null ? list2 : list1;
			return ret.next;
		}
	}
}