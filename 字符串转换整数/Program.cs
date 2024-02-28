using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace 字符串转换整数
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string test = "+-";
			Console.WriteLine(MyAtoi(test));
		}

		public static int MyAtoi(string s)
		{
			//如果是空字符串，按照题意，返回0
			if (s == "")
				return 0;

			int result = 0;
			//将字符串转换为字符数组
			char[] chars = s.ToCharArray();
			int index = 0;
			int fuHao = 1;
			int length = chars.Length;

			//第一步 删空格
			while (index < length && chars[index] == ' ')
			{ 
				index++;
			}

			//第二步 有无符号
			if (index < length && chars[index]=='-') 
			{
				fuHao = -1;
				index++;
			}
			else if (index < length && chars[index] == '+')
			{
				index++;
			}

			//第三步 对数字进行处理
			while (index < length && chars[index]-'0'<=9&& chars[index] - '0' >= 0)
			{
				long temp = result * 10 + chars[index] - '0';

				if ((temp + '0' - chars[index])/10!=result && fuHao == 1)
				{
					return int.MaxValue;
				}
				else if ((temp + '0' - chars[index]) / 10 != result && fuHao == -1)
				{
					return int.MinValue;
				}

				result = (int)temp;
				index++;
			}

			return result * fuHao;
		}
	}
}