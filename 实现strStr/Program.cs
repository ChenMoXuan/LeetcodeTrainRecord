namespace 实现strStr
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str1 = "abcdaadbd";
			string str2 = "aad";

			Console.WriteLine(StrStr(str1,str2));
			
		}

		public static int StrStr(string haystack, string needle) {

			if (needle.Length==0)
			{
				return 0;
			}

			int i = 0;
			int j = 0;

			int[] next = new int[needle.Length];
			GetNext(needle, next);
			while (i < haystack.Length && j < needle.Length)
			{
				if (j == -1 || haystack[i] == needle[j])
				{
					i++;
					j++;
				}
				else
				{
					j = next[j];
				}
				if (j==needle.Length)
				{
					return i - j;
				}
			}
			
			return -1;
		}

		private static void GetNext(string p, int[]next)
		{
			int len = p.Length;
			int i = 0;
			int j = -1;
			next[0] = -1;

			while (i<len-1)
			{
				if (j == -1 || p[i] == p[j])
				{
					i++;
					j++;
					next[i] = j;
				}
				else
				{
					j = next[j];
				}
			}
		}
	}
}