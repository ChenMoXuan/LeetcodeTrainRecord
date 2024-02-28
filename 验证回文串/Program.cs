using System.Text.RegularExpressions;

namespace 验证回文串
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
		}

		public static bool IsPalindrome(string s)
		{
			
			if (s == "")
				return true;

			//去掉所有非字母数字字符
			s = Regex.Replace(s, @"[^a-zA-Z0-9]", "");
			s = s.ToLower();

			int left = 0;
			int right = s.Length - 1;

			while (left < right)
			{
				if (s[left] != s[right])
				{
					return false;
				}
				left++;
				right--;
			}


			return true;

		}
	}
}