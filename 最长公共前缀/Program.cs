namespace 最长公共前缀
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] strs = { "a", "ab"};
			Console.WriteLine(LongestCommonPrefix(strs));
		}

		public static string LongestCommonPrefix(string[] strs)
		{
			//排除极端情况，存在空字符
			if (strs.Contains("")) return "";
			if (strs.Length == 1) return strs[0];

			//共同下标
			int index = 0;
			//数组下标
			int i = 0;

			while (true)
			{
				
				if (strs[0].Substring(0, index) == strs[i].Substring(0, index))
				{ 
					//数组下标触底反弹
					if (i == strs.Length-1)
					{
						i = -1;
						index++;
					}

					//准备下一个比对对象
					i++;

					//检查当前数组下标是否超出下一个比对对象长度，如果超出，则下标-1返回
					if (index > strs[i].Length)
					{
						index--;
						break;
					}
				}
				else
				{
					index--;
					break;
				}
			}

			
			return strs[0].Substring(0,index);
		}
		
	}
}