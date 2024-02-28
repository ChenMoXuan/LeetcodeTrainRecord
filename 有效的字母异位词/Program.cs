using System.Linq;

namespace 有效的字母异位词
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string s = "rat";
			string t = "car";

			Console.WriteLine(isAnagram(s,t));
		}

		public static bool isAnagram(string s, string t)
		{
			//长度是否相等，不等返回false
			if (s.Length!=t.Length)
			{	
				return	false;
			}

			//长度相等，转换成字符数组
			char[] s_CharArray = s.ToCharArray();
			char[] t_CharArray = t.ToCharArray();

			//声明两个字典
			Dictionary<char,int> FirstDic = new Dictionary<char,int>();
			Dictionary<char,int> SecondDic = new Dictionary<char,int>();

			//遍历添加字典
			for (int i = 0; i < s_CharArray.Length; i++)
			{
				//第一字典
				if (!FirstDic.ContainsKey(s_CharArray[i]))
				{
					FirstDic.Add(s_CharArray[i], 1);
				}
				else
				{
					FirstDic[s_CharArray[i]]++;
				}

				//第二字典
				if (!SecondDic.ContainsKey(t_CharArray[i]))
				{
					SecondDic.Add(t_CharArray[i], 1);
				}
				else
				{
					SecondDic[t_CharArray[i]]++;
				}
			}

			//遍历查找（可以用foreach）
			for (int i = 0; i < SecondDic.Count; i++)
			{
				char tempKey = SecondDic.Keys.ElementAt(i);

				if (!FirstDic.ContainsKey(tempKey) || FirstDic[tempKey] != SecondDic[tempKey])
				{
					return false;
				}
			}

			return true;
		}
	}
}