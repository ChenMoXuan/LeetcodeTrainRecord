namespace LeetCode
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "aabb";
			Console.WriteLine("不重复字符出现的索引是:" + FindOnlyChar(test));
		}


		public static int FindOnlyChar(string s)
		{
			//将字符串 s 转换为 字符数组 chars
			char[] chars = s.ToCharArray();
			
			for (int i = 0; i < chars.Length; i++)
			{
				int firstTemp = s.IndexOf(chars[i]);
				int lastTemp = s.LastIndexOf(chars[i]);

				//如果不是一个值，说明存在重复字符 开始下一次循环
				if (firstTemp != lastTemp)
					continue;
				else
					//如果找到了不重复的字符，返回其所在的索引
					return firstTemp;		
			}

			//如果没有找到重复的，返回-1
			return -1;
		}
	}
}