namespace 整数反转
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int temp = 1534236469;

			Console.Write(Revert2(temp));

		}

		public static int Revert(int num)
		{
			//一个空字符串
			string reverse = string.Empty;

			if (num<0)
			{
				reverse += "-";
			}

			//将传输进来的数字转换为字符数组
			char[] charArray = num.ToString().ToCharArray();

			for (int i = charArray.Length - 1; i >=0; i--)
			{
				if (charArray[i].Equals('-'))
					continue;
				
				reverse += charArray[i];
			}

			long endNum = long.Parse(reverse);

			if (endNum > int.MaxValue || endNum < int.MinValue)
				return 0;

			return (int)endNum;
		}

		public static int Revert2(int num)
		{
			int res = 0;
			while (num != 0)
			{
				int t = num % 10;
				int newRes = res * 10 + t;
				//如果数字溢出，直接返回0
				if ((newRes - t) / 10 != res)
					return 0;
				res = newRes;
				num = num / 10;
			}
			return res;
		}
	}
}