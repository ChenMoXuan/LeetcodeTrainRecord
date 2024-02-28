namespace 外观数列
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(CountAndSay(6));
		}

		public static string CountAndSay(int n)
		{
			string str = "1";
			for (int i = 0; i < n - 1; i++)
			{
				str = ElementCount(str);
			}

			return str;
		}

		private static string ElementCount(string p)
		{
			//声明一个空字符串
			string str = "";
			//当前元素
			char nowElement = '0';
			//计数
			int elementNum = 1;

			//字符串处理
			for (int i = 0; i < p.Length; i++)
			{
				if (i == 0)
				{
					nowElement = p[i];
					continue;
				}

				if (nowElement == p[i])
				{
					elementNum++;
				}
				else
				{
					//添加
					str += elementNum;
					str += nowElement;
					//重置
					nowElement = p[i];
					elementNum = 1;
				}
			}

			str += elementNum;
			str += nowElement;

			return str;
		}
	}
}